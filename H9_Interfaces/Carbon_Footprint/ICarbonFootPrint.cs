namespace H9_Interfaces.Carbon_Footprint
{
    interface ICarbonFootPrint
    {
        /// <Kleine_Uitleg>
        /// 
        /// hier is een fout die ik had gemaakt die mischien jullie krijgen zonder dat jullie het door hebben:
        /// als je bv: de methode :
        /// 
        ///*     int BerekenFootPrint{
        /// 
        ///      return 0;
        /// 
        ///      *}
        /// 
        /// als je het zo aanmaakt zal het niet bereikbaar zijn voor de andere klassen;
        /// scrhijf het zoals volgend ==>
        /// 
        /// </summary>

        int BerekenFootprint();
        void VerlaagFootprint();
        void BevragenVanFootprint();

    }
}

