using System;

namespace CeaserCipher
{
    public static class CipherManager
    {
        public static string EncipherMessage(String message, int displacement){
            return ConvertMessageToString(ShuffleForward(ConvertToASCII(message), displacement));
        }

        public static string DecipherMessage(string message, int displacement){
            return ConvertMessageToString(ShuffleBakcward(ConvertToASCII(message), displacement));
        }

        private static int[] ConvertToASCII(String s){
            int[] text = new int[s.Length];

            var index = 0;
            foreach(var c in s){
                text[index++] = (int) c;
            }

            return text;
        }

        private static int[] ShuffleForward(int[] message, int displacement){

            int[] encipheredMessage = new int[message.Length];
            int index = 0;
            foreach(var c in message){
                if(c<91 && c>64){
                    if((c+displacement)>90){
                            encipheredMessage[index++] = c+displacement-26;
                        } else{
                            encipheredMessage[index++] = c+displacement;
                        }
                } else if(c<123 && c>60){
                    if((c+displacement)>122){
                            encipheredMessage[index++] = c+displacement-26;
                        } else{
                            encipheredMessage[index++] = c+displacement;
                        }
                } else{
                     encipheredMessage[index++] = c;
                }
            }

            return encipheredMessage;
        }

        private static int[] ShuffleBakcward(int[] message, int displacement){
            int[] decipheredMessage = new int[message.Length];
            int index = 0;
            foreach(var c in message){
                if(c<91 && c>64){
                    if((c-displacement)<65){
                            decipheredMessage[index++] = c-displacement+26;
                        } else{
                            decipheredMessage[index++] = c-displacement;
                        }
                } else if(c<123 && c>60){
                    if((c-displacement)<61){
                            decipheredMessage[index++] = c-displacement+26;
                        } else{
                            decipheredMessage[index++] = c-displacement;
                        }
                } else{
                     decipheredMessage[index++] = c;
                }
            }

            return decipheredMessage;
        }

        private static string ConvertMessageToString(int[] encipheredMessage){
            string descryptedMessage = "";

            foreach(var em in encipheredMessage){
                descryptedMessage += Convert.ToChar(em);
            }

            return descryptedMessage;
        }
    }
}