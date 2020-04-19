package com.example.appandroid.API.ApiServive;

import com.example.appandroid.Assistir;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.GET;
import retrofit2.http.POST;

public interface AssistirService {

    @GET("api/Assistirs")
    Call<List<Assistir>> getAssistents();

    @POST("api/Assistirs")
    Call<Assistir> insertAsistencia(@Body Assistir evento);


}
