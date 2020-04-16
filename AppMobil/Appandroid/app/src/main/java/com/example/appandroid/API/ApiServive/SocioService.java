package com.example.appandroid.API.ApiServive;

import com.example.appandroid.Socio;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.GET;

public interface SocioService {

    @GET("api/Socis")
    Call<List<Socio>> getSocis();

}
