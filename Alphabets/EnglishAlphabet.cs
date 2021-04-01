using System;
using System.Collections.Generic;

public class EnglishAlphabet{
    public Dictionary<byte, char> vowels = new Dictionary<byte, char>(){
            {1,'a'},{2,'e'},{3,'i'},{4,'o'},{5,'u'},{6,'y'}
        };

    public Dictionary<byte, char> consonants = new Dictionary<byte, char>(){
            {1,'b'},{2,'c'},{3,'d'},{4,'f'},{5,'g'},{6,'h'},{7,'j'},
            {8,'k'},{9,'l'},{10,'m'},{11,'n'},{12,'p'},{13,'q'},{14,'r'},
            {15,'s'},{16,'t'},{17,'v'},{18,'w'},{19,'x'},{20,'y'},{21,'z'}
    };
}