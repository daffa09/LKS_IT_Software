package com.tutor.lkstest1.api;

import android.view.Menu;

import java.util.List;
import java.util.Observable;

import retrofit2.Call;
import retrofit2.http.GET;
import retrofit2.http.POST;
import retrofit2.http.Part;
import retrofit2.http.Path;
import retrofit2.http.Query;

public interface MenuApi {

    @GET("menu")
    Observable<List<Menu>> getMenu();

    @POST("menu/{id}")
    Observable<Menu> saveMenu(
            @Query("name") String name,
            @Query("description") String description,
            @Query("price") Integer price
    );

    @POST("delete/menu/{id}")
    Observable<Integer> deleteMenu(
            @Path("id") String id
    )


}
