package com.example.appandroid;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;
import androidx.fragment.app.Fragment;

public class Perfil extends Fragment {


    Button btnModPassword, btnLogout;

    Socio socio = null;
    public Perfil(Socio socio){

        this.socio = socio;

    }
    @Nullable
    @Override
    public View onCreateView(@NonNull LayoutInflater inflater, @Nullable ViewGroup container, @Nullable Bundle savedInstanceState) {


        View v = inflater.inflate(R.layout.activity_perfil, container, false);

        btnModPassword = v.findViewById(R.id.btnModPassword);
        EditText nombre = (EditText) v.findViewById(R.id.txtNombre);
        EditText direccion = (EditText) v.findViewById(R.id.txtApellidos);
        EditText telefon = (EditText) v.findViewById(R.id.txtTelefono);

        nombre.setText(socio.getNom());
        direccion.setText(socio.getCognoms());
        telefon.setText(socio.getTelefon());
        btnModPassword.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(getActivity(), Login.class);
                intent.putExtra("socio", socio);
                startActivity(intent);
            }
        });

        btnLogout = v.findViewById(R.id.btnLogout);

        btnLogout.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                getActivity().finish();


                startActivity(new Intent(getActivity(), Login.class));
            }
        });

        return v;

    }
}
