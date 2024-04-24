namespace UnityLibrary.TTS
{
    // https://json2csharp.com/
    public class Data
    {
        public string s_key { get; set; }
        public string v_str { get; set; }
        public string duration { get; set; }
        public string speaker { get; set; }
    }

    public class Extra
    {
        public string log_id { get; set; }
    }

    public class Root
    {
        public Data data { get; set; }
        public Extra extra { get; set; }
        public string message { get; set; }
        public int status_code { get; set; }
        public string status_msg { get; set; }
    }
}