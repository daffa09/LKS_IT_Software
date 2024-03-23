package com.tutor.lkstest1;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
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

import java.util.Observable;

import io.reactivex.android.schedulers.AndroidSchedulers;
import io.reactivex.observers.DisposableObserver;
import io.reactivex.schedulers.Schedulers;

public class RegistrasiActivity extends AppCompatActivity implements View.OnClickListener{

    private Button btnRegis;
    private EditText txtUsername, txtPassword, txtPasswordConfirm;
    private static final String TAG = "RegistrasiActivity";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_registrasi);
        App.setmContext(this);
        btnRegis = (Button)findViewById(R.id.btnRegistrasi);
        txtUsername = (EditText) findViewById(R.id.txtName);
        txtPassword = (EditText) findViewById(R.id.txtPassword);
        txtPasswordConfirm = (EditText) findViewById(R.id.txtNameConfirmPass);
        btnRegis.setOnClickListener(this);

    }

    public void regis(String username, String password) {
        /** Create handle for the RetofitInstance interface */
        AkunApi service = RetrofitInstance.getRetrofitInstance().create(AkunApi.class);
        Observable<Akun> listObservable = service.register(username, password);
        listObservable.subscribeOn(Schedulers.io())
                .observabeOn(AndroidSchedulers.mainThread())
                .subscribeWith(new DisposableObserver<Akun>() {
                    @Override
                    public void onNext(Akun akun) {
                        try {
                            Log.d(TAG, "Masuk");
                            Toast.makeText(getApplicationContext(), "Berhasil", Toast.LENGTH_SHORT);
                            Intent i = new Intent(getApplicationContext(), DetailMenuActivity.class);
                            startActivity(i);
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

    @Override
public void onCLick(View v) {
        switch (v.getId()) {
            case R.id.btnRegistrasi: /** Start a new activity mycards.java */
                if (txtUsername.getText().length() <= 0){
                    Log.d(TAG, "MASUK1");
                    Toast.makeText(getApplicationContext(), "Harap isi Username", Toast.LENGTH_SHORT);
                } else if (txtPassword.getText().length() <= 0) {
                    Log.d(TAG, "MASUK2");
                    Toast.makeText(getApplicationContext(), "Harap isi Password", Toast.LENGTH_SHORT);
                } else if (!txtPassword.getText().toString().equals(txtPasswordConfirm.getText().toString())) {
                    Log.d(TAG, "MASUK3");
                    Toast.makeText(getApplicationContext(), "Konfirmasi password tidak sama", Toast.LENGTH_SHORT);
                } else {
                    Log.d(TAG, "MASUK4");
                    regis(txtUsername.getText().toString(), txtPassword.getText().toString());
                }
                break;
        }
    }
}