int[,] tablero=new int [5,5];

    void paso1_crear_tablero(){
    for (int f=0;f < tablero.GetLength(0); f++)    {
        for (int c=0; c< tablero.GetLength(1); c++) {
        
        }

    }


}

void paso2_colocar_barcos()
{
    tablero[4, 3] = 1;
    tablero[1, 1] = 1;
    tablero[2, 1] = 1;
    tablero[3, 4] = 1;
}

void paso3_imprimir_tablero(){
    string caracter_imprimir="";
    for (int f = 0; f < tablero.GetLength(0); f++){
        for (int c = 0; c < tablero.GetLength(1); c++){

            switch(tablero[f,c])
            {
                case 0:
                    caracter_imprimir = "~";
                    break;
                case 1:
                    caracter_imprimir = "-";
                    break;
                case -1:
                    caracter_imprimir = "*";
                    break;
                case -2:
                    caracter_imprimir = "X";
                    break;
            }
            Console.Write(caracter_imprimir + " ");
        }
        Console.WriteLine();
    }

}

void paso4_ingreso_coordenadas(){
    int fila, columna = 0;
    do
    {
        Console.Write("ingrese la fila");
        fila=Convert.ToInt32(Console.ReadLine());
        Console.Write("ingresa la columna:");
        columna= Convert.ToInt32(Console.ReadLine());

        if (tablero[fila,columna]== 1){
        Console.Beep();
        tablero[fila, columna] = -1;//bandera que ya le dio.
    } else { 
        tablero[fila, columna] = -2; //fallo el tiro 
    }
    Console.Clear();
    paso3_imprimir_tablero();

    }while (true) ;

        }


paso1_crear_tablero();
paso2_colocar_barcos();
paso3_imprimir_tablero ();
paso4_ingreso_coordenadas();
