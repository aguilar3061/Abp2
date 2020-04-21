package com.example.appandroid.API.ApiServive;

import com.example.appandroid.Evento;


import java.util.List;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.GET;
import retrofit2.http.PUT;
import retrofit2.http.Path;

public interface EsdevenimentsService {

    @GET("api/Esdeveniments")
    Call<List<Evento>> getEventos();

    @PUT("api/Esdeveniments/{id}")
    Call<Evento> updateEsdeveniments(@Path("id") int id, @Body Evento evento);

    @GET("api/Esdeveniments/{id}")
    Call<Evento> getEvento();




}
