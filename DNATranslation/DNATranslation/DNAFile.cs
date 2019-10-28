using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

namespace DNATranslation
{
    class DNAFile
    {
        public DNAFile()
        {
            DirectoryInfo currDir = new DirectoryInfo(".");
            string textFilePath = currDir.FullName + @"\dna.txt";
            
        }

        public String initDNAFile(string exampleDNA)
        {
            
            //So they way DNA -> RNA works is that 5 prime to 3 Prime DNA is transcribed to create RNA,so the complementary pairs are AUCG in RNA meaning that if there is an A it changes to U, T -> A, G -> C etc.
            var exampleRNA = String.Join("", exampleDNA.Select(x => x == 'A' ? 'U' :
                                                                    x == 'T' ? 'A' :
                                                                    x == 'G' ? 'C' :
                                                                    x == 'C' ? 'G' :
                                                                    x));
            return exampleRNA;
        }
        public String[] createCodon(string getRNA)
        {
            //codons are triplets of RNA ex AUG 
            //polypetides always start with AUG which codes for Met
            int splitBy = 3;
            //codons have to be 3 in length so adding trailing A's as a temporary fix
            while (getRNA.Length % 3 != 0)
            {
                getRNA += "A";
            }
            int itemsInArray = getRNA.Length / 3;
            string[] codon = new String[itemsInArray+100];
            codon[0] = "AUG";
            int stringLength = getRNA.Length;
            for (int i = 0; i < stringLength; i += splitBy)
            {
                codon[i+1] = (getRNA.Substring(i, splitBy));
            }

            return codon;

        }
        public String[] replaceCodonPeptide (string[] codon)
        {
            codon = codon.Select(s => s.Replace("AUG", "Methionine")).ToArray();
            codon = codon.Select(s => s.Replace("AUC", "Isoleucine")).ToArray();
            codon = codon.Select(s => s.Replace("AUU", "Isoleucine")).ToArray();
            codon = codon.Select(s => s.Replace("AUA", "Isoleucine")).ToArray();
            codon = codon.Select(s => s.Replace("GUU", "Valine")).ToArray();
            codon = codon.Select(s => s.Replace("GUA", "Valine")).ToArray();
            codon = codon.Select(s => s.Replace("GUC", "Valine")).ToArray();
            codon = codon.Select(s => s.Replace("GUG", "Valine")).ToArray();
            codon = codon.Select(s => s.Replace("CUU", "Leucine")).ToArray();
            codon = codon.Select(s => s.Replace("CUC", "Leucine")).ToArray();
            codon = codon.Select(s => s.Replace("CUA", "Leucine")).ToArray();
            codon = codon.Select(s => s.Replace("CUG", "Leucine")).ToArray();
            codon = codon.Select(s => s.Replace("UUU", "Phenylalanine")).ToArray();
            codon = codon.Select(s => s.Replace("UUC", "Phenylalanine")).ToArray();
            codon = codon.Select(s => s.Replace("UUA", "Leucine")).ToArray();
            codon = codon.Select(s => s.Replace("UUG", "Leucine")).ToArray();
            codon = codon.Select(s => s.Replace("UCU", "Serine")).ToArray();
            codon = codon.Select(s => s.Replace("UCC", "Serine")).ToArray();
            codon = codon.Select(s => s.Replace("UCA", "Serine")).ToArray();
            codon = codon.Select(s => s.Replace("UCG", "Serine")).ToArray();
            codon = codon.Select(s => s.Replace("CCU", "Proline")).ToArray();
            codon = codon.Select(s => s.Replace("CCC", "Proline")).ToArray();
            codon = codon.Select(s => s.Replace("CCA", "Proline")).ToArray();
            codon = codon.Select(s => s.Replace("CCG", "Proline")).ToArray();
            codon = codon.Select(s => s.Replace("ACU", "Threonine")).ToArray();
            codon = codon.Select(s => s.Replace("ACC", "Threonine")).ToArray();
            codon = codon.Select(s => s.Replace("ACA", "Threonine")).ToArray();
            codon = codon.Select(s => s.Replace("ACG", "Threonine")).ToArray();
            codon = codon.Select(s => s.Replace("GCU", "Alanine")).ToArray();
            codon = codon.Select(s => s.Replace("GCC", "Alanine")).ToArray();
            codon = codon.Select(s => s.Replace("GCA", "Alanine")).ToArray();
            codon = codon.Select(s => s.Replace("GCG", "Alanine")).ToArray();
            codon = codon.Select(s => s.Replace("UAU", "Tyrosisne")).ToArray();
            codon = codon.Select(s => s.Replace("UAC", "Tyrosisne")).ToArray();
            codon = codon.Select(s => s.Replace("UAA", "STOP")).ToArray();
            codon = codon.Select(s => s.Replace("UAG", "STOP")).ToArray();
            codon = codon.Select(s => s.Replace("CAU", "Histidine")).ToArray();
            codon = codon.Select(s => s.Replace("CAC", "Histidine")).ToArray();
            codon = codon.Select(s => s.Replace("CAA", "Glutamine")).ToArray();
            codon = codon.Select(s => s.Replace("CAG", "Glutamine")).ToArray();
            codon = codon.Select(s => s.Replace("AAU", "Asparagine")).ToArray();
            codon = codon.Select(s => s.Replace("AAC", "Asparagine")).ToArray();
            codon = codon.Select(s => s.Replace("AAA", "Lysine")).ToArray();
            codon = codon.Select(s => s.Replace("AAG", "Lysine")).ToArray();
            codon = codon.Select(s => s.Replace("GAU", "Aspartic acid")).ToArray();
            codon = codon.Select(s => s.Replace("GAC", "Aspartic acid")).ToArray();
            codon = codon.Select(s => s.Replace("GAA", "Glutamic acid")).ToArray();
            codon = codon.Select(s => s.Replace("GAG", "Glutamic acid")).ToArray();
            codon = codon.Select(s => s.Replace("UGU", "Cysteine")).ToArray();
            codon = codon.Select(s => s.Replace("UGC", "Cysteine")).ToArray();
            codon = codon.Select(s => s.Replace("UGA", "STOP")).ToArray();
            codon = codon.Select(s => s.Replace("UGG", "Tryptophane")).ToArray();
            codon = codon.Select(s => s.Replace("CGU", "Arginine")).ToArray();
            codon = codon.Select(s => s.Replace("CGC", "Arginine")).ToArray();
            codon = codon.Select(s => s.Replace("CGA", "Arginine")).ToArray();
            codon = codon.Select(s => s.Replace("CGG", "Arginine")).ToArray();
            codon = codon.Select(s => s.Replace("AGU", "Serine")).ToArray();
            codon = codon.Select(s => s.Replace("AGC", "Serine")).ToArray();
            codon = codon.Select(s => s.Replace("AGA", "Arginine")).ToArray();
            codon = codon.Select(s => s.Replace("AGG", "Arginine")).ToArray();
            codon = codon.Select(s => s.Replace("GGU", "Glycine")).ToArray();
            codon = codon.Select(s => s.Replace("GGC", "Glycine")).ToArray();
            codon = codon.Select(s => s.Replace("GGA", "Glycine")).ToArray();
            codon = codon.Select(s => s.Replace("GGG", "Glycine")).ToArray();
            return codon;
        }

    }
}
