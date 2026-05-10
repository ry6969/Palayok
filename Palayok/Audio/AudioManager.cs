using System;
using System.Collections.Generic;
using System.IO;
using NAudio.Wave;
using System.Text;
using NAudio.Wave;


namespace Palayok.Audio
{
    public class LoopStream : WaveStream
    {
        private readonly WaveStream sourceStream;

        public LoopStream(WaveStream sourceStream)
        {
            this.sourceStream = sourceStream;
        }

        public override WaveFormat WaveFormat => sourceStream.WaveFormat;

        public override long Length => sourceStream.Length;

        public override long Position
        {
            get => sourceStream.Position;
            set => sourceStream.Position = value;
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            int totalBytesRead = 0;

            while (totalBytesRead < count)
            {
                int bytesRead = sourceStream.Read(buffer, offset + totalBytesRead, count - totalBytesRead);

                if (bytesRead == 0)
                {
                    sourceStream.Position = 0;
                }
                else
                {
                    totalBytesRead += bytesRead;
                }
            }

            return totalBytesRead;
        }
    }
    public static class AudioManager
    {
        private static Dictionary<string, string> backgroundMusic = new();
        private static Dictionary<string, string> soundEffects = new();
        private static List<WaveOutEvent> activeSfx = new();

        private static WaveOutEvent currentMusicOutput;
        private static AudioFileReader currentMusicReader;

        private static WaveStream currentMusicStream;

        // Event to report loading progress
        public static event Action<string> OnLoadingProgress;

        private static bool isMuted = false;

        private static float previousMusicVolume = 1.0f;
        private static float previousSfxVolume = 1.0f;

        private static float musicVolume = 1.0f;
        private static float sfxVolume = 1.0f;



        /// <summary>
        /// Loads all audio files (background music and sound effects)
        /// </summary>
        public static void LoadAllAudio()
        {
            try
            {
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string projectRoot = Path.GetFullPath(Path.Combine(basePath, "..", "..", ".."));
                string audioPath = Path.Combine(projectRoot, "Resources", "Audio");

                System.Diagnostics.Debug.WriteLine($"Audio path: {audioPath}");
                System.Diagnostics.Debug.WriteLine($"Audio path exists: {Directory.Exists(audioPath)}");

                // Load Background Music
                ReportProgress("Loading background music...");
                LoadBackgroundMusic(audioPath);

                // Load Sound Effects
                ReportProgress("Loading sound effects...");
                LoadSoundEffects(audioPath);

                ReportProgress("Audio loading complete!");
                System.Diagnostics.Debug.WriteLine($"Background music count: {backgroundMusic.Count}");
                System.Diagnostics.Debug.WriteLine($"Sound effects count: {soundEffects.Count}");
            }
            catch (Exception ex)
            {
                ReportProgress($"Error loading audio: {ex.Message}");
                System.Diagnostics.Debug.WriteLine($"Audio loading error: {ex}");
            }
        }

        private static void LoadBackgroundMusic(string audioPath)
        {
            string musicPath = Path.Combine(audioPath, "BackgroundMusic");

            if (!Directory.Exists(musicPath))
            {
                ReportProgress("Background music directory not found");
                return;
            }

            // Load background tracks
            string[] musicFiles = { "Track1.wav", "Track2.wav" };

            foreach (var file in musicFiles)
            {
                string fullPath = Path.Combine(musicPath, file);
                if (File.Exists(fullPath))
                {
                    string key = Path.GetFileNameWithoutExtension(file);
                    backgroundMusic[key] = fullPath;
                    ReportProgress($"Loaded: {key}");
                }
            }
        }

        private static void LoadSoundEffects(string audioPath)
        {
            string effectsPath = Path.Combine(audioPath, "SoundEffects");

            if (!Directory.Exists(effectsPath))
            {
                ReportProgress("Sound effects directory not found");
                return;
            }

            // Load all sound effect files
            string[] effectFiles = Directory.GetFiles(effectsPath, "*.wav");

            foreach (var file in effectFiles)
            {
                string key = Path.GetFileNameWithoutExtension(file);
                soundEffects[key] = file;
                ReportProgress($"Loaded: {key}");
            }
        }

        /// <summary>
        /// Play background music
        /// </summary>
        public static void PlayBackgroundMusic(string musicName, bool loop = true)
        {
            if (!backgroundMusic.ContainsKey(musicName))
                return;

            StopBackgroundMusic(); // IMPORTANT: central cleanup

            currentMusicReader = new AudioFileReader(backgroundMusic[musicName]);
            currentMusicReader.Volume = isMuted ? 0f : musicVolume;

            currentMusicStream = loop
                ? new LoopStream(currentMusicReader)
                : currentMusicReader;

            currentMusicOutput = new WaveOutEvent();
            currentMusicOutput.Init(currentMusicStream);
            currentMusicOutput.Play();
        }

        /// <summary>
        /// Play sound effect (one-time)
        /// </summary>
        public static void PlaySoundEffect(string effectName)
        {
            if (!soundEffects.ContainsKey(effectName))
                return;

            var audioFile = new AudioFileReader(soundEffects[effectName]);
            var output = new WaveOutEvent();

            output.Init(audioFile);

            // track it
            activeSfx.Add(output);

            output.Play();

            output.PlaybackStopped += (s, e) =>
            {
                output.Dispose();
                audioFile.Dispose();
                activeSfx.Remove(output);
            };
        }

        /// <summary>
        /// Stop background music
        /// </summary>
        public static void StopBackgroundMusic()
        {
            if (currentMusicOutput != null)
            {
                currentMusicOutput.Stop();
                currentMusicOutput.Dispose();
                currentMusicOutput = null;
            }

            if (currentMusicStream != null)
            {
                currentMusicStream.Dispose();
                currentMusicStream = null;
            }

            if (currentMusicReader != null)
            {
                currentMusicReader.Dispose();
                currentMusicReader = null;
            }
        }

        public static void StopAllSoundEffects()
        {
            foreach (var sfx in activeSfx)
            {
                sfx.Stop();
                sfx.Dispose();
            }

            activeSfx.Clear();
        }

        public static void ToggleMute()
        {
            isMuted = !isMuted;

            if (currentMusicReader != null)
            {
                currentMusicReader.Volume = isMuted ? 0f : musicVolume;
            }

            OnMuteChanged?.Invoke(isMuted);
        }

        private static void ReportProgress(string message)
        {
            OnLoadingProgress?.Invoke(message);
        }

        /// <summary>
        /// Check if audio is loaded
        /// </summary>
        public static bool IsMuted => isMuted;
        public static event Action<bool> OnMuteChanged;
        public static bool IsAudioLoaded => backgroundMusic.Count > 0 && soundEffects.Count > 0;
    }
}
