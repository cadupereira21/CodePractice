namespace CeaserCipher
{
    public class CypherManager
    {
        String entry = "";
        String output = "";

        private CypherManager(String s){
            this.entry = s;
        }

        public void EncryptMessage(String message, int displacement){
            
        }

        private int[] ConvertToASCII(String s){
            s = s.ToLower();
            int[] text = new int[s.Length];

            var index = 0;
            foreach(var c in s){
                text[index++] = (int) c;
            }

            return text;
        }

        private int[] Shuffle(int[] entry){
            foreach(var c in entry){
                
            }
        }
    }
}