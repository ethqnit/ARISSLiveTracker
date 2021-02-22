using System.Collections.Generic;
using System;

[Serializable]
public class Info
   {
        public string satname;
        public int satid;
        public int transactionscount;
    }
[Serializable]
    public class Position    
    {
      public double satlatitude;
        public double satlongitude; 
        public double sataltitude;
        public string error;

    }
[Serializable]
    public class Root   
    {
        public Info info;
        public List<Position> positions; 
    }