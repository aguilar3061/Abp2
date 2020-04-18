package com.example.appandroid.API.ApiServive;

import com.example.appandroid.Comunitat;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.GET;

public interface ComunitatService {

    @GET("api/Comunitats")
    Call<List<Comunitat>> getComunidades();

}
