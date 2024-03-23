package com.tutor.lkstest1;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

import com.tutor.lkstest1.api.MenuApi;
import com.tutor.lkstest1.service.App;
import com.tutor.lkstest1.service.RetrofitInstance;

import java.util.List;
import java.util.Observable;

import io.reactivex.android.schedulers.AndroidSchedulers;
import io.reactivex.observers.DisposableObserver;
import io.reactivex.schedulers.Schedulers;

public class MenuActivity extends AppCompatActivity implements View.OnClickListener {

    private static final String TAG = "MenuActivity";
    private Button btnAdd;
    private EditText txtName, txtDesc, txtPrice;

    @Override
    protected void onCreate(Bundle savedInstanceState) {

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_menu);
        App.setmContext(this);
        btnAdd = (Button)findViewById(R.id.btnFormRegis);
        txtName = (EditText)findViewById(R.id.txtName);
        txtDesc = (EditText)findViewById(R.id.txtDescription);
        txtPrice = (EditText)findViewById(R.id.txtprice);

        if (getIntent().getExtras() != null) {
            Bundle bundle = getIntent().getExtras();
            txtName.setText(bundle.getString("name"));
            txtDesc.setText(bundle.getString("desc"));
            txtPrice.setText(bundle.getString("price"));
        }
        btnAdd.setOnClickListener(this);

    }

    public void onCLick(View v) {
        switch (v.getId()) {
            case R.id.btnFormRegis:
                if (getIntent().getExtras() != null) {
                    Bundle bundle = getIntent().getExtras();
                    AksiMenu(bundle.getString("id"),txtName.getText().toString(), txtDesc.getText().toString(), Integer.parseInt(txtPrice.getText().toString()));
                } else {
                    AksiMenu(null,txtName.getText().toString(), txtDesc.getText().toString(), Integer.parseInt(txtPrice.getText().toString()));
                }
                break;
        }
    }

    public void AksiMenu(String id, String name, String desc, Integer price) {

        Log.d(TAG, "Masuk");
        MenuApi service = RetrofitInstance.getRetrofitInstance().create(MenuApi.class);
        Observable<Menu> listObservable;
        if (id == null) {
            listObservable = service.saveMenu(name,desc,price);
        } else {
            listObservable = service.updateMenu(id,name,desc,price);
        }

        listObservable.subscribeOn(Schedulers.io())
                .observeOn(AndroidSchedulers.mainThread())
                .subscribeWith(new DisposableObserver<Menu>(){
                    @Override
                    public void onNext(Menu data) {
                        try {
                            Log.d(TAG, "Masuk");
                            Toast.makeText(getApplicationContext(), "Data Berhasil", Toast.LENGTH_SHORT);
                            Intent i = new Intent(getApplicationContext(), DetailMenuActivity.class);
                            startActivity(i);
                        } catch (Exception e) {
                            Log.d(TAG, e.getMessage());
                            Toast.makeText(getApplicationContext(), e.getMessage(), Toast.LENGTH_SHORT);
                        }
                    }

                    @Override
                    public void onError(Throwable e) { Log.e(TAG, e.getMessage()); }
                    @Override
                    public void onComplete() { Log.e(TAG, "Selesai"; }
                });

    }

}