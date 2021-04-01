using System;
using System.Collections.Generic;

namespace VNameGenerator{
    public static class NameGenerator{
        public static string GenerateName(int nameLength)
        {
            string name = String.Empty;
            string ending = String.Empty;

            Random random = new Random();
            bool isConsonantFirst = random.NextBoolean();
            bool isConsonantNext = !isConsonantFirst;

            if(nameLength % 2 == 0){
                if(isConsonantFirst){

                    name += random.NextChar(true);
                    for(int i = 0; i < nameLength - 1; i++){
                        if(isConsonantNext){
                            name += random.NextChar(true);
                            isConsonantNext = !isConsonantNext;
                        }
                        else{
                            name += random.NextChar(false);
                            isConsonantNext = !isConsonantNext;
                        }
                    }

                    return name;
                }
                else{
                    name += random.NextChar(false);

                    for(int i = 0; i < nameLength - 1; i++){
                        if(isConsonantNext){
                            name += random.NextChar(true);
                            isConsonantNext = !isConsonantNext;
                        }
                        else{
                            name += random.NextChar(false);
                            isConsonantNext = !isConsonantNext;
                        }
                    }

                    return name;
                }
            }
            else if(nameLength % 2 != 0){
                if(isConsonantFirst){
                    name += random.NextChar(true);
                }
                else{
                    name += random.NextChar(false);
                }
                for(int i = 0; i < nameLength - 1; i++){
                    if(isConsonantNext){
                        name += random.NextChar(true);
                        isConsonantNext = !isConsonantNext;
                    }
                    else{
                        name += random.NextChar(false);
                        isConsonantNext = !isConsonantNext;
                    }
                }
                return name;
            }
            return String.Empty;
        }
    }
}