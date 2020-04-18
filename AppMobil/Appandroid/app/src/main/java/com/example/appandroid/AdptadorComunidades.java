package com.example.appandroid;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import java.util.ArrayList;

public class AdptadorComunidades extends ArrayAdapter<Comunitat> {


    private Context context;
    private ArrayList<Comunitat> datos;

        /*Lo primero que encontramos
        es el constructor para nuestro adaptador, al que sólo
        pasaremos el contexto (que normalmente será la actividad
        desde la que se crea el adaptador) y la lista de
        datos a mostrar, que en nuestro caso es un lista de
        objetos de tipo Persona. En este constructor tan sólo
        llamaremos al constructor padre tal como ya vimos al
        principio de este artículo, pasándole nuestros dos
        parámetros (contexto y datos) y el ID del layout que
        queremos utilizar (en nuestro caso el nuevo que hemos
        creado, item_lista_persona).*/

    public AdptadorComunidades(Context context, ArrayList<Comunitat> datos) {

        super(context, R.layout.item_list_comunitats, datos);

        this.context = context;
        this.datos = datos;

    }


    public View getView(int position, View convertView, ViewGroup parent) {

            /*
            El método getView() se llamará cada vez que haya que mostrar un
            elemento de la lista. Lo primero que debe hacer es «inflar» el layout XML
            que hemos creado. Esto consiste en consultar el XML de nuestro layout y crear
            e inicializar la estructura de objetos java equivalente. Para ello, crearemos
            un nuevo objeto LayoutInflater y generaremos la estructura de objetos mediante
            su método inflate(id_layout).
            */

        LayoutInflater inflater = LayoutInflater.from(getContext());

        View item = inflater.inflate(R.layout.item_list_comunitats, null);


        //Rellenamos uno y cada uno de los campos que hay en el xml item_lista_persona (
        //los que te interesen claro)lo mas importante aqui son el item.
        //cuando se define el TextView y el campo de dato.get() para assignar el valor.

        TextView txtViewNombre = (TextView) item.findViewById(R.id.idTextNombreComunidad);
        txtViewNombre.setText(datos.get(position).getNom());



        // i devolvera el item entro
        return (item);
    }
}