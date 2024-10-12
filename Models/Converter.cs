namespace FirstProject.Models {
    public class Converter {
            
       private static readonly double rate = 24610; // 1 usd = rate vnd 

        public double result ;
        public void convertUSDtoVND(double _value ) {
            result  = _value * rate ;
        }

    }
}
