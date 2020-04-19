package com.example.appandroid;

import android.content.Context;
import android.net.Uri;
import android.os.Bundle;

import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;

public class FragmentUbicacion extends Fragment {

    Evento eventoo = null;

    public FragmentUbicacion(Evento eventoo) {

        this.eventoo = eventoo;

    }


    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
        // Inflate the layout for this fragment
        return inflater.inflate(R.layout.fragment_ubicacion, container, false);
    }

    @Override
    public void onActivityCreated(Bundle state) {
        super.onActivityCreated(state);



        TextView txtDescr = (TextView) getView().findViewById(R.id.idUbicacion);
        txtDescr.setText(eventoo.getDireccio());





    }

}
