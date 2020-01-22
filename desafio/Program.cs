using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace desafio
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
            
            //String[] lines = File.ReadAllLines("codigo_java_limpo.txt", Encoding.Default);
            int num_linhas = 0;
            int num_linhas_final = 0;
            string texto="";
            int i=0, j=0,cont_linha_coment=0;
            
            //comentarios
            int posicao_abre_comentario=0;
            int posicao_fecha_comentario=0;
            int posicao_comentario_barras_dupla=0;
            int posicao_ponto_virgula=0;
            int posicao_abre_chaves=0;

            Console.WriteLine("Entre com o caminho do arquivo:  obs:.(caminho+nome do arquivo.txt) \n");    
            string a = Console.ReadLine();    
            String[] lines = File.ReadAllLines(a, Encoding.Default);
            

            Console.WriteLine("\nConteúdo do arquivo.txt: ");

            //conta total de linhas do arquivo sem verificacoes
            foreach(var line in lines)
            {             
                        num_linhas++;
                        Console.WriteLine(num_linhas + " : " + line );            
            }


            //controle dos comentários
            num_linhas_final=num_linhas;
            Console.WriteLine("Total de linhas sem verificacoes:" + num_linhas_final);
            for(i=0; i<num_linhas; i++)
            {   
                texto = Convert.ToString(lines[i]);
                Console.WriteLine($"\nLinha:{i+1}");
                Console.WriteLine(lines[i]);
                
                // valor da posicao '-1' se nao ocorrer, '0' em diante pq ocorreu
                posicao_abre_comentario = texto.IndexOf("/*");
                posicao_fecha_comentario = texto.IndexOf("*/");
                posicao_comentario_barras_dupla = texto.IndexOf("//");
                posicao_ponto_virgula = texto.IndexOf(";");
                posicao_abre_chaves = texto.IndexOf("{");
                Console.WriteLine("Posicao_abre_comentario:" + posicao_abre_comentario);
                Console.WriteLine("Posicao_fecha_comentario:" + posicao_fecha_comentario);
                Console.WriteLine("Posicao_comentario_barras_dupla:" + posicao_comentario_barras_dupla);
                Console.WriteLine("posicao_ponto_virgula:" + posicao_ponto_virgula);
                Console.WriteLine("posicao_abra_chaves:" + posicao_abre_chaves);
                
                if (string.IsNullOrWhiteSpace(texto) )
                {
                    Console.WriteLine("Linha em branco encontrada, linha decrementada");
                    num_linhas_final--;                    
                }

                //condicoes para barras dupla
                if(posicao_comentario_barras_dupla!=-1)
                {
                    if(posicao_ponto_virgula==-1) //no caso de nao haver virgula na linha e ser um comentario
                    {
                        if(posicao_abre_chaves==-1)
                        {
                        num_linhas_final--;
                        Console.WriteLine("Comentario barras dupla valido, linha decrementada");
                        }
                    }
                }

                //condicoes para comentarios /*  */
                if ( (posicao_abre_comentario >= 0) && (posicao_fecha_comentario>posicao_abre_comentario) && (posicao_fecha_comentario<posicao_ponto_virgula) )
                {                 
                    Console.WriteLine("Linha com comentario entre comandos");                   
                }
                else
                if( (posicao_abre_comentario >= 0) && (posicao_fecha_comentario==-1) )
                {
                        i++; //procurar na proxima linha pelo */
                        cont_linha_coment++;
                        for(j=i; j<num_linhas_final; j++)
                        {
                            cont_linha_coment++;
                            texto = Convert.ToString(lines[j]); //proxima linha até achar */
                            posicao_fecha_comentario = texto.IndexOf("*/");
                            if( (posicao_fecha_comentario!=-1) )
                            {
                                Console.WriteLine("Linha decrementada,fecha comentario encontrado na linha:" + j);
                                Console.WriteLine("Posicao_fecha_comentario:" + posicao_fecha_comentario);
                                ///Console.WriteLine("Cont_coment:" + cont_linha_coment);                                
                                i=j;
                                num_linhas_final = num_linhas_final-cont_linha_coment; 
                                j=num_linhas_final;//força saida do loop depois de achar */                                
                            }
                        }    
                }


            }

            //após filtros dos comentarios numero total de linhas do arquivo
            Console.WriteLine("\nNUMERO TOTAL DE LINHAS DO ARQUIVO É:" + num_linhas_final);
            Console.WriteLine("NOME: ANDRÉ FLORES DOS SANTOS");


            Console.ReadKey();

        }
    }
}
