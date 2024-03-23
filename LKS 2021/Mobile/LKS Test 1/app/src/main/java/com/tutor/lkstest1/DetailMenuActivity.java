package com.tutor.lkstest1;

import androidx.appcompat.app.AppCompatActivity;
import androidx.appcompat.view.menu.ListMenuItemView;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Toast;

import com.google.android.material.floatingactionbutton.FloatingActionButton;
import com.tutor.lkstest1.adapter.MenuAdapter;
import com.tutor.lkstest1.api.MenuApi;
import com.tutor.lkstest1.model.Menu;
import com.tutor.lkstest1.service.App;
import com.tutor.lkstest1.service.RetrofitInstance;

import java.util.ArrayList;
import java.util.List;
import java.util.Observable;

import io.reactivex.android.schedulers.AndroidSchedulers;
import io.reactivex.observers.DisposableObserver;
import io.reactivex.schedulers.Schedulers;

public class DetailMenuActivity extends AppCompatActivity implements MenuAdapter.ItemClickListener {

    private static final String TAG = "DetailMenuActivity";
    private Lsit<Menu> menuList = new ArrayList<>();
    MenuAdapter adapter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_detail_menu);
        App.setmContext(this);
        getMenu();
        FloatingActionButton fab = findViewById(R.id.fab);
        fab.setOnClickListener(new View.OnClickListener(){
            @Override
            public void onClick(View view) {
                Intent i = new Intent(getApplicationContext(), MenuAksiActivity.class);
                startActivity(i);
            }
        });
        // set up the RecycleView
    }

    public void setAdapter() {
        RecyclerView recyclerView = findViewById(R.id.rvMenu);
        recyclerView.setHasFixedSize(true);
        recyclerView.setLayoutManager(new LinearLayoutManager(this));
        adpater = new MenuAdapter(this, menuList);
        adapter.setOnclickListener(this);
        adapter.notifyDataSetChanged();
        recyclerView.setAdapter(adapter);
    }

    @Override
    public void onItemClick(View v, int position) {

    }

    public void getMenu() {
        /** Create handle for the RetrofitInstance interface */
        MenuApi service = RetrofitInstance.getRetrofitInstance().create(MenuApi.class);
        Observable<List<Menu>> listObservable = service.getMenu();
        listObservable.subscribeOn(Schedulers.io())
                .observeOn(AndroidSchedulers.mainThread())
                .subscribeWith(new DisposableObserver<List<Menu>>() {

                    @Override
                    public void onNext(List<Menu> menus) {
                        try {
                            Log.d(TAG, "Masuk");
                            menuList.menus;
                            setAdapter();
                            Toast.makeText(getApplicationContext(), "Data  Barhasil", Toast.LENGTH_SHORT);
                        } catch (Exception e) {
                            Log.d(TAG, e.getMessage());
                            Toast.makeText(getApplicationContext(), e.getMessage(), Toast.LENGTH_SHORT);
                        }
                    }

                    @Override
                    public void onError(Throwable e) {
                        Log.e(TAG, e.getMessage());
                    }

                    @Override
                    public void onComplete() {
                        Log.d(TAG, "Selesai");
                    }

                });
    }

        public void deleteMenu(String id) {

            MenuApi service = RetrofitInstance.getRetrofitInstance().create(MenuApi.class);
            Observable<Integer> listObservable = service.deleteMenu();
            listObservable.subscribeOn(Schedulers.io())
                    .observeOn(AndroidSchedulers.mainThread())
                    .subscribeWith(new DisposableObserver<Integer>(){

                        @Override
                        public void onNext(Integer data) {
                            try {
                                Log.d(TAG, "Masuk");
                                Toast.makeText(getApplicationContext(), "Data Berhasil", Toast.LENGTH_SHORT);
                            }catch (Exception e) {
                                Log.d(TAG, e.getMessage());
                                Toast.makeText(getApplicationContext(), e.getMessage(), Toast.LENGTH_SHORT);
                            }
                        }

                    });

        }

}