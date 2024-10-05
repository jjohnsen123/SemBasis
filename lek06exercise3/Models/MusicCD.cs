namespace lek06exercise3.Models
{
    public class MusicCD : Product
    {
        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }
        public List<string> Tracks { get; set; } = new List<string>();




        public void AddTrack(string track)
        {
            Tracks.Add(track);
        }
    }
}
