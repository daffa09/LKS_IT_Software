package com.tutor.lkstest1.api;

import java.util.Observable;
import io.reactivex.Observable;
import retrofit2.http.POST;
import retrofit2.http.Query;


public interface AkunApi {

    @POST("login")
    Observable<Akun> login(
            @Query("username") String name,
            @Query("password") String description

    );

    @POST("register")
    Observable<Akun> register(
            @Query("username") String name,
            @Query("password") String description

    );

}
