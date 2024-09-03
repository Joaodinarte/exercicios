{
            Console.WriteLine("Digite um número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Selecione a operação: ");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            int operacao = Convert.ToInt32(Console.ReadLine());
            int resultado = 0;

            if (operacao == 1)
            {
                resultado = numero1 + numero2;
            }
            else if (operacao == 2)
            {
                resultado = numero1 - numero2;
            }
            else if (operacao == 3)
            {
                resultado = numero1 * numero2;
            }
            else if (operacao == 4)
            {
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                }
                else
                {
                    Console.WriteLine("Divisão por zero não é permitida.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Operação inválida.");
                return;
            }

            Console.WriteLine("O resultado é: " + resultado);
        }
