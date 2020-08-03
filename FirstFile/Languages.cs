namespace FirstFile
{
    // public enum Languages
    public enum Languages : byte
    {
        /*
         * A set of name/value pairs (constants).
         *  where we use enum class
         *  suppose you are creating shipping company you have some methods
            One way use consts 
            const int RegularAirMail =1;
            const int RegisterAirMail = 2;
            const int Express = 3;
            
            another way use enum class
         */
        
         RegularAirMail =1,
         RegisterAirMail = 2,
         Express = 3
         
     // var method = Languages.Express; use like this example     
        
    }
}