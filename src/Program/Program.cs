using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el contacto dueño
            Contact contacto1 = new Contact("Dueno");
            Phonebook contactoDueño = new Phonebook(contacto1);
          

            // Crear la lista de contactos
            Contact contacto2 = new Contact("Sibi");
            contacto2.Phone = "+59897073253";
            contactoDueño.AñadirContacto(contacto2);

            Contact contacto3 = new Contact("Tadeo");
            contacto3.Phone = "+59895417777";
            contactoDueño.AñadirContacto(contacto3);

            // Agregar contactos a la lista
            String[] listaContactos = new String[4];
            listaContactos[0] = "Sibi";
            listaContactos[1] = "Tadeo";
            

            // Enviar un correo a algunos contactos

            // Enviar un WhatsApp a algunos contactos

            Message mensaje1 = new TwitterMessages(contactoDueño, listaContactos);
            mensaje1.Text = "PruebaGrupo8/ Hola";
            Twitter.Send(mensaje1);

            // Enviar un SMS a algunos contactos

            Message mensaje2 = new WhatsAppMessages(contactoDueño, listaContactos);
            mensaje2.Text = "PruebaGrupo8/ Hola";
            WhatsApp.Send(mensaje2);

        }
    }
}
