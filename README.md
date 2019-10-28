# DNATranslation
5' 3' **DNA** to **RNA** **transcription** than translated to **amino acids**  
  
Initialization of any **gene expression** is done by the first step which is transcription of DNA. DNA needs to be copied to make an RNA molecule. Usually RNA molecules must be processed after transcription, they need to spliced to get rid of **extrons**, for the purpose of this program we should assume that the DNA sequence is all **introns**. 
  
So the program takes a DNA Sequence then transcribes it with the **complementary base pairs** for RNA.  
A --> U  
T --> A  
G --> C  
C --> G  
  
The program can also split the sequence in triplets and in the case that there are too few to create triplets trailing A's will be added to the end of it.
Just in case the sequence doesn't start with Methionine, the array will automatically be initialized with it.  
So an example of the output would be:  
AUG  
GGA  
UUA 
  
Triplets of RNA bases are called **Codons** each codon codes for a specfic amino acid, and a chain of amino acids are a **peptide**
So the program can also change triplets to the proper amino acid.

#### Later updates
  
- Take in files of sequences
- create a method that will create random dna sequences
- make it more visually appealing

#### Definitions
  
**DNA**: Deoxyribonucleic Acid is the hereditary material in almost all organisms. Fun fact more than 99% of human DNA are the same in all people no matter how different they look.  
**RNA**:Riboneuclic Acid for most life forms is used in coding, decoding, regulation and the expression of genes.  
**Transcription**: The process where DNA is copied to RNA.  
**Translation**: The process where RNA is used to produce amino acids --> peptides --> proteins.  
**Gene Expression**: the process by whihc the instructions in our DNA are converted into a functional product such as protein.  
**extrons**: Non-coding DNA.  
**introns**: Coding DNA.  
**Complementary Base Pairs**: In DNA Guanine always hydrogen bonds to Cystosine and Adenine always binds to thymine, but in RNA thymine is replaced with uracil.  
**codon**: Sequence of three DNA or RNA nucleotides that corresponds with a specific amino acid or stop signal during protein synthesis  
**peptide**: Short chain of amino acids.
