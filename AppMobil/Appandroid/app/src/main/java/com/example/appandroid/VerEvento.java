package com.example.appandroid;

import androidx.appcompat.app.AppCompatActivity;

import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.util.Base64;
import android.widget.ImageView;
import android.widget.TextView;

public class VerEvento extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_ver_evento);


        final Evento obj = (Evento) getIntent().getExtras().getSerializable("evento1");

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
