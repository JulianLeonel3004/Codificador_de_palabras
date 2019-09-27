using System;
using System.Collections.Generic;
using System.Text;

namespace Codificador_de_palabras
{
    public class Codificar
    {
        public static String Codificador(String cadena)
        {
            String[,] mat = { { " ", "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z" },
                              { "0","2","22","222","3","33","333","4","44","444","5","55","555","6","66","666","7","77","777","7777","8","88","888","9","99","999","9999"} };

            String decodificado = null;
            int j, cont = 0, pos = -1, largo = cadena.Length, posini,posfin;
            bool error = false;
            char caracter;



            while (cont < largo && !error)
            {

                error = true;

                for (j = 0; j < 27; j++)
                {

                    if (String.Equals(mat[0, j], cadena[cont].ToString()))
                    {
                        pos = j;
                        j = 27;
                        error = false;
                    }

                }

                if (pos >= 0)
                {
                    if (decodificado != null)
                    {
                       
                        posfin = decodificado.Length - 1;
                      

                        if (cont > 0 && mat[1, pos].Substring(0, 1).Equals(decodificado[posfin].ToString())) //Valida que el anterior número sea igual al que se está por mapear
                            decodificado += " ";
                    }

                    decodificado += mat[1, pos];
                    pos = -1;
                }

                cont++;
            }

            if (error)
                decodificado = "Error de caracteres, solo se pueden ingresar letras minusculas y espacios";
            return decodificado;


        }
    }
}
