package com.example.appandroid.API.ApiServive;

import com.example.appandroid.Assistir;
import com.example.appandroid.Evento;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.GET;
import retrofit2.http.POST;
import retrofit2.http.PUT;
import retrofit2.http.Path;

public interface AssistirService {

    @GET("api/Assistirs")
    Call<List<Assistir>> getAssistents();

    @POST("api/Assistirs")
    Call<Assistir> insertAsistencia(@Body Assistir assistir);


    @GET("api/Assistirs/{id}")
    Call<List<Assistir>> getAssistentsDeUnSocio(@Path("id") int id);



    @PUT("api/Assistirs/{id}")
    Call<Assistir> updateAsistir(@Path("id") int id, @Body Assistir assistir);




}
