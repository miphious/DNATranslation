using System;
using System.Linq;

namespace DNATranslation
{
    class Program
    {
        static void Main(string[] args)
        {
            DNAFile dNA = new DNAFile();
            //Method to test out if anything actually works
            string exampleDNA = "ATGACGTTATTCTACTTTGATTGTGCGAGACAATGCTACCTTACCGGTCGGAACTCGATCGGTTGAACTCTATCACGCCTGGTCTTCGAAGTTAGCACA";
            string getRNA = dNA.initDNAFile(exampleDNA);

            Console.WriteLine(getRNA);
            String[] getCodon = dNA.createCodon(getRNA);
            String[] codon = getCodon.Where(c => c != null).ToArray();
            //test to seee if codons are split by three
            Array.ForEach(codon, Console.WriteLine);
            Console.WriteLine();
            //replaces codon with amino acid 
            String[] peptide = dNA.replaceCodonPeptide(codon);
            Array.ForEach(peptide, Console.WriteLine);
        }
    }
}
