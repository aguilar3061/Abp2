package com.example.appandroid;
import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;

public class VerEvento extends AppCompatActivity  {



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ver_evento);



     //   final Evento obj = (Evento) getIntent().getExtras().getSerializable("evento1");



        //final Socio soci = (Socio) getIntent().getSerializableExtra("socio");



     /*   TextView txtViewNombre = (TextView)findViewById(R.id.idNombre);
        ImageView img = (ImageView) findViewById(R.id.idImgEventoo);


        txtViewNombre.setText( obj.getNombreEvento());
        String imgByte = obj.getImagen();
        try{

            byte [] encodeByte= Base64.decode(imgByte,Base64.DEFAULT);
            Bitmap bitmap= BitmapFactory.decodeByteArray(encodeByte, 0, encodeByte.length);
            img.setImageBitmap(bitmap);

        }catch(Exception e){
            e.getMessage();
        }
*/



    }

}
