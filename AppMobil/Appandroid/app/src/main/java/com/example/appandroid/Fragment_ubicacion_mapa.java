package com.example.appandroid;

import androidx.fragment.app.FragmentActivity;

import android.content.Intent;
import android.net.Uri;
import android.os.Bundle;

import com.google.android.gms.maps.CameraUpdateFactory;
import com.google.android.gms.maps.GoogleMap;
import com.google.android.gms.maps.OnMapReadyCallback;
import com.google.android.gms.maps.SupportMapFragment;
import com.google.android.gms.maps.model.BitmapDescriptor;
import com.google.android.gms.maps.model.BitmapDescriptorFactory;
import com.google.android.gms.maps.model.LatLng;
import com.google.android.gms.maps.model.Marker;
import com.google.android.gms.maps.model.MarkerOptions;

public class Fragment_ubicacion_mapa extends FragmentActivity implements OnMapReadyCallback {

    private GoogleMap mMap;
    private Marker infoMarker;
    final Evento evento = (Evento) getIntent().getExtras().getSerializable("evento1");

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_fragment_ubicacion_mapa);
        // Obtain the SupportMapFragment and get notified when the map is ready to be used.
        SupportMapFragment mapFragment = (SupportMapFragment) getSupportFragmentManager()
                .findFragmentById(R.id.map);
        mapFragment.getMapAsync(this);
    }


    /**
     * Manipulates the map once available.
     * This callback is triggered when the map is ready to be used.
     * This is where we can add markers or lines, add listeners or move the camera. In this case,
     * we just add a marker near Sydney, Australia.
     * If Google Play services is not installed on the device, the user will be prompted to install
     * it inside the SupportMapFragment. This method will only be triggered once the user has
     * installed Google Play services and returned to the app.
     */
    @Override
    public void onMapReady(GoogleMap googleMap) {
        mMap = googleMap;

        // Dirección
/*
        Uri gmmIntentUri = Uri.parse("geo:0,0?z=10&q=" + evento.getDireccio());
        Intent mapIntent = new Intent(Intent.ACTION_VIEW, gmmIntentUri);
        mapIntent.setPackage("com.google.android.apps.maps");
        startActivity(mapIntent);
*/

        // // // // MARCADOR // // // //
        LatLng latLng = new LatLng(41.388777, 2.173039);
        // Marcador con Nombre y Descripción del evento.
        // DAVID --> (no se si funciona por que no me funciona la api)
        mMap.addMarker(new MarkerOptions().position(latLng).title(evento.getNombreEvento())).setSnippet("Haz click para extender la descripción del evento.");
        //Animación de zoom
        mMap.animateCamera(CameraUpdateFactory.newLatLngZoom(latLng, 18), 5000, null);






    }

}