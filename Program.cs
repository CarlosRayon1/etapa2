#include <stdio.h>
#include <string.h>

struct Cliente
{ //Estructura de informacion del cliente
    int clientes;
    char Nombre[50];
    char Apellidopaterno[50];
    char Apellidomaterno[50];
    char Modelodevehiculoacomprar[20];
    char Correo[15];
    int Numerodetelefono;
};

struct Cliente Datos();
void imprimircliente(struct Cliente cliente);
void guardarCliente(struct Cliente cliente);
void cargarCliente();
void eliminarCliente();

#define MAX_CLIENTES 30
struct Cliente cliente[MAX_CLIENTES];
int numClientes = 0;

struct Cliente Datos(){

        struct Cliente cliente;

printf("Numero del cliente: ");
scanf("%d", &(cliente.clientes));
printf("Nombre del Cliente: ");
scanf("%s", cliente.Nombre);
printf("Apellido Paterno: ");
scanf("%s", cliente.Apellidopaterno);
printf("Apellido Materno: ");
scanf("%s", cliente.Apellidomaterno);
printf("Vehiculo comprado: ");
scanf("%s", cliente.Modelodevehiculoacomprar);
printf("Correo de uso personal: ");
scanf("%s", cliente.Correo);
printf("Numero telefonico de uso personal: ");
scanf("%d", &(cliente.Numerodetelefono));

printf("Registro exitoso");

return cliente;
}

void guardarCliente(struct Cliente cliente){
	FILE*file= fopen(struct Cliente cliente);
if (file == NULL)
{
    printf("no se pudo guardar informacion");
    return 0;
}
fprintf(file, "%d %s %s %s %s %s %d", cliente.clientes, cliente.Nombre, cliente.Apellidopaterno,
cliente.Apellidomaterno, cliente.Modelodevehiculoacomprar, cliente.Correo, cliente.Numerodetelefono);
fclose(file);
}

void eliminarClientes(inr numeroCliente)
{
    FILE* file = fopen
}

int main()
{

    int opcion, numeroCliente;

    do
    {
        printf("\n\t\t     Menu Principal \n");
        printf("\n1. Alta del cliente \n");
        printf("\n2. Baja del cliente \n");
        printf("\n3. Modificaciones del cliente \n");
        printf("\n4. Mostrar todos \n");
        printf("\n5. Busqueda del cliente \n");
        printf("\n6. Modelos de los carros \n");
        printf("\n7. Salir \n");

        printf("\n\nIntroducir opcion: ");
        scanf("%d", &opcion);

        switch (opcion)
        {
            case 1:
                printf("\n\t\t Alta del cliente \n\n ");
                if (numClientes < MAX_CLIENTES)
                {
                    cliente[numClientes] = Datos();
                    guardarClientes(clientes[numClientes]);
                    printf("Registro exitoso ");
                    numClientes++;
                }
                else
                {
                    printf("ERROR: no se puede agragar mas clientes.");
                }
                break;

            case 2:
                printf("\n\t\t Baja del cliente \n ");
                scanf("%d", &numeroCliente);
                eliminarCliente(numeroCliente);
                break;

            case 3:
                printf("\n\t\t Modificaciones del cliente \n ");
                printf("1. Numero del cliente: \n ");
                printf("2. Nombre: \n ");
                printf("3. Apellido Paterno: \n ");
                printf("4. Apellido Materno: \n ");
                printf("5. Vehiculo comprado: \n ");
                printf("6. Correo de uso personal: \n ");
                printf("7. Numero telefonico persolnal: \n ");

                printf("8. Regresar al menu principal\n ");
                break;

            case 4:
                printf("\n\t\t Mostrar todos \n ");
                printf("1. Regresar al menu principal\n ");
                break;

            case 5:
                printf("\n\t\t Busqueda del cliente \n ");
                printf("Numero del cliente");
                printf("1. Regresar al menu principal\n ");
                break;

            case 6:
                printf("\n\t\t Modelos de los carros \n ");
                printf("tesla cybertruck model y 2024 ");
                printf("tesla roadster 2022 \n ");
                printf("tesla model s 2022 \n");
                printf("tesla model y 2022 \n");
                printf("tesla model x 2020 \n");
                printf("wagen Sedan 1980 \n");
                printf("1. Regresar al menu principal\n ");
                break;

        }
    } while (opcion != 8);
    return 0;
}
