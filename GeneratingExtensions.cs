using System;

///
/// <summary>Provides random generators for something</summary>
///
public static class GeneratingExtensions{
    ///
    /// <summary>Returns random bool value</summary>
    ///
    public static bool NextBoolean(this Random random){
        byte variant = (byte)random.Next(1, 3);
        if(variant == 1) return true;
        else return false;
    }

    ///
    /// <summary>Returns random char value</summary>
    ///
    public static char NextChar(this Random random, bool isConsonant){
        EnglishAlphabet englishAlphabet = new EnglishAlphabet();
        byte number = 0;
        if(isConsonant){
            number = (byte)random.Next(1, 21);
            return englishAlphabet.consonants[number];
        }
        else{
            number = (byte)random.Next(1, 6);
            return englishAlphabet.vowels[number];
        }
    }
}