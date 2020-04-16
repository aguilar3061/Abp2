package com.example.appandroid.API.ApiServive;

import com.example.appandroid.Evento;


import java.util.List;

import retrofit2.Call;
import retrofit2.http.GET;

public interface EsdevenimentsService {

    @GET("api/Esdeveniments")
    Call<List<Evento>> getEventos();
}
