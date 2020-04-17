package com.example.appandroid.API.ApiServive;

import com.example.appandroid.Socio;

import java.util.List;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.GET;
import retrofit2.http.POST;
import retrofit2.http.PUT;
import retrofit2.http.Path;

public interface SocioService {

    @GET("api/Socis")
    Call<List<Socio>> getSocis();

    @POST("api/Socis")
    Call<Socio> insertSocio(@Body Socio socio);

    @PUT("api/Socis/{id}")
    Call<Socio> updateSocio(@Path("id") int id, @Body Socio socio);

    /*
    * EXEMPLE
    *
    * Socio soci = null;
        Call<Socio> InsertSocio = socioService.insertSocio(soci);

        InsertSocio.enqueue(new Callback<Socio>() {
            @Override
            public void onResponse(Call<Socio> call, Response<Socio> response) {
            switch (response.code()){
                    case 201:
                        socio = response.body();
                        break;
                    case 400:
                        Gson gson = new Gson();
                        MensajeError mensajeError = gson.fromJson(response.errorBody().charStream(),MensajeError.class)
                        Toast.makeText(getApplicationContext(),mensajeError.getMensaje(), Toast.LENGTH_LONG).show();
                        break;
            }

            @Override
            public void onFailure(Call<Socio> call, Throwable t) {

            }
        });
    *
    *
    *
    *
    *
    *
    *
    * */

}
