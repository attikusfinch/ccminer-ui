namespace ccminer_gui
{
    class DefaultConfig : IConfig
    {
        public string Intensity => "19.5";

        public string Username => "USER.SLABBER";
        public string Password => "x";
        public string PoolUrl => "stratum+tcp://161.97.172.98:4444";

        public int StatsAvg => 60;

        public string Algorithm => "UFOCOIN";
    }
}
