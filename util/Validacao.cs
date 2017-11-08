﻿using System;

namespace util
{
    public class Validacao
    {
        public bool ValidarCPF(String docCliente)
            {
            int[] chave1 = {10,9,8,7,6,5,4,3,2};
            int[] chave2 = {11,10,9,8,7,6,5,4,3,2};

            string primeiroDigito, segundoDigito;

            docCliente = LimparPontos(docCliente);

            Console.WriteLine(docCliente);
            
            if(docCliente.Length<11){
                Console.WriteLine("CNPJ inválido!");
                return false;
            }

            if(docCliente=="00000000000" || docCliente=="11111111111" || docCliente=="22222222222"
            || docCliente=="33333333333" || docCliente=="44444444444" || docCliente=="55555555555"
            || docCliente=="66666666666" || docCliente=="77777777777" || docCliente=="88888888888"
            || docCliente=="99999999999")
            {
                Console.WriteLine("CPF inválido!");
                return false;
            }

            primeiroDigito = ValidaDigito(docCliente,chave1,1);

            if (primeiroDigito != docCliente.Substring(chave1.Length,1))
            {
                Console.WriteLine("CPF inválido!");
            }
            else
            {
                segundoDigito = ValidaDigito(docCliente,chave2,1);

            if (docCliente.EndsWith(segundoDigito) == true)
            {
                return true;
            }
            else
            {
                Console.WriteLine("CPF inválido!");
            }

            }

        return false;

        }



        public bool ValidarCNPJ(String docCliente)

            {

            int[] chave1 = {5,4,3,2,9,8,7,6,5,4,3,2};

            int[] chave2 = {6,5,4,3,2,9,8,7,6,5,4,3,2};

            string primeiroDigito, segundoDigito;

            docCliente = LimparPontos(docCliente);
            Console.WriteLine(docCliente);

            if(docCliente.Length<14){
                Console.WriteLine("CNPJ inválido!");
                return false;
            }

            primeiroDigito = ValidaDigito(docCliente,chave1,2);


            if (primeiroDigito != docCliente.Substring(chave1.Length,1))
            {
                Console.WriteLine("CNPJ inválido!");
                return false;
            }
            else
            {
                segundoDigito = ValidaDigito(docCliente,chave2,2);



                if (docCliente.EndsWith(segundoDigito) == true)

                {
                    return true;
                }

                else

                {
                    Console.WriteLine("CNPJ inválido!");
                }
            }

        return false;

        }

        private static string ValidaDigito(string doc, int[] chave, int tipoDoc)
        {

       int soma = 0, resto = 0;

       string tempdoc;

       tempdoc = doc.Substring(0,chave.Length);

       for(int i=0;i<chave.Length;i++){
                soma += Convert.ToInt16(tempdoc[i].ToString())*chave[i];
        }

            resto = soma % 11;

            if(resto<2)
            {
                return "0";        
            }
            else
            {
                return (11-resto).ToString();
            }

        }

        private static string LimparPontos(string doc)
        {
            doc=doc.Replace(".","");
            doc=doc.Replace("-","");
            doc=doc.Replace(" ","");
            doc=doc.Replace("/","");
            
            Console.WriteLine("doc "+doc);

            return doc;
        }

    }
}
