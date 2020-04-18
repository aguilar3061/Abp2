package com.example.appandroid.API.ApiServive;

import com.example.appandroid.Assistir;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.GET;

public interface AssistirService {

    @GET("api/Assistirs")
    Call<List<Assistir>> getAssistents();

}
