package com.tutor.lkstest1;

import androidx.activity.result.contract.ActivityResultContracts;
import androidx.appcompat.app.AppCompatActivity;


import android.content.Intent;
import android.icu.text.Bidi;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.tutor.lkstest1.api.AkunApi;
import com.tutor.lkstest1.model.Akun;
import com.tutor.lkstest1.service.App;
import com.tutor.lkstest1.service.RetrofitInstance;

import java.net.Inet4Address;
import java.util.Observable;

import io.reactivex.android.schedulers.AndroidSchedulers;
import io.reactivex.observers.DisposableMaybeObserver;
import io.reactivex.schedulers.Schedulers;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    private Button btnLogin, btnRegistrasi;
    private EditText txtName, txtPassword;
    private static final String TAG = "MainActivity";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        App.setmContext(this);
        setContentView(R.layout.activity_main);
        btnLogin = (Button) findViewById(R.id.btnLogin);
        btnRegistrasi = (Button) findViewById(R.id.btnRegistrasi);
        txtName = (EditText) findViewById(R.id.txtName);
        txtPassword = (EditText) findViewById(R.id.txtPassword);
        btnLogin.setOnClickListener(this);
        btnRegistrasi.setOnClickListener(this);

        setContentView(R.layout.activity_main);
    }


    public void login(String username, String password) {

        AkunApi service = RetrofitInstance.getRetrofitInstance().create(AkunApi.class);
        Observable<Akun> listObservable = service.login(username, password);
        listObservable.subscribeOn(Schedulers.mainThread())
                .observeOn(AndroidSchedulers.mainThread())
                .subscribeWith(new DisposableMaybeObserver<Akun>() {
                    @Override
                    public void onNext(Akun akun) {
                        try {
                            Log.d(TAG, "Masuk");
                            Toast.makeText(getApplicationContext(), "Berhasil Login", Toast.LENGTH_SHORT);
                            Intent i = new Intent(getApplicationContext(), DetailMenuActivity.class);
                            startActivity(i);
                        } catch (Exception e) {
                            Log.d(TAG, e.getMessage());
                            Toast.makeText(getApplicationContext(), e.getMessage(), Toast.LENGTH_SHORT);
                        }
                    }

                    @Override
                    public void onError(Throwable e) {
                        Log.d(TAG, e.getMessage());
                    }

                    @Override
                    public void onComplete() {
                        Log.d(TAG, "Selesai");
                    }
                });

    }


    @Override
    public void onClick(View v) {
        switch (V.getId()) {
            case R.id.btnLogin: /** Start a new activity MyCards.java */
                if (txtName.getText().length() <= 0) {
                    Toast.makeText(getApplicationContext(), "Harap Isi Username", Toast.LENGTH_LONG);
                } else if (txtPassword.getText().length() <= 0) {
                    Toast.makeText(getApplicationContext(), "Harap Isi Passsword", Toast.LENGTH_LONG);

                } else {
                    login(txtName.getText().toString(), txtPassword.getText().toString());
                }
                break;

            case R.id.btnAdd: /** AlertDialog when click on exit */
                Intent i = new Intent(getApplicationContext(), RegistrasiActivity.class);
                startActivity(i);
                break;
        }
    }
}