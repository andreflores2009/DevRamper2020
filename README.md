# DevRamper2020
DevRamper2020

Linguagem utilizada C# com Visual Studio Code

Desafio
O desafio tem como objetivo analisar a lógica utilizada na resolução do problema. A forma
de organização e representação das informações ficam a cargo do participante, entretanto é
necessário criar uma interface para que o usuário interaja com o desafio. Vale ressaltar que
não serão permitidas cópias retiradas da internet que acarretarão a desclassificação do
candidato. Abaixo são listadas as linguagens permitidas para este desafio.
Linguagens permitidas:
● C#
● Java
● PHP
O problema:
Contando linhas de código
Desenvolva um utilitário que conte o número de linhas de código efetivo em um
arquivo-fonte em Java. Considere uma linha se ela não contiver apenas caracteres em
branco ou texto dentro de comentários. Alguns exemplos:
- // This file contains 3 lines of code
1 public interface Dave {
- /**
- * count the number of lines in a file
- */
2 int countLines(File inFile); // not the real signature!
3 }
- /*****
- * This is a test program with 5 lines of code
- * \/* no nesting allowed!
- //*****//***/// Slightly pathological comment ending...
-
1 public class Hello {
2 public static final void main(String [] args) { // gotta love Java
- // Say hello
3 System./*wait*/out./*for*/println/*it*/("Hello/*");
4 }
-
5 }
Lembre-se que comentários em Java podem ser ou "//" até o final de uma linha, ou "/*" até
encontrar "*/". Podem existir múltiplos "/*...*/" comentário em uma linha. Caracteres em
branco incluem tabulações, espaçamentos e quebras de linha. Comentários dentro de string
Java devem ser ignorados.
Desafio retirado do site.
http://dojopuzzles.com/problemas/exibe/contando-linhas-de-codigo/
