package com.example.lks_jabar_testing_java.ui;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;

import com.example.lks_jabar_testing_java.R;
import com.example.lks_jabar_testing_java.helper.Message;
import com.example.lks_jabar_testing_java.helper.Service;

public class MainActivity extends AppCompatActivity implements View.OnClickListener{

    private Service service = new Service();
    private Button btnLogin,btnRegis;
    private EditText txtUsername, txtPassword;
    private static final String TAG = "MainActivity";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        service.setVersion();

        btnLogin = (Button)findViewById(R.id.btnLogin);
        btnRegis = (Button)findViewById(R.id.btnRegistrasi);
        txtUsername = (EditText) findViewById(R.id.txtName);
        txtPassword = (EditText) findViewById(R.id.txtPassword);
        btnLogin.setOnClickListener(this);
        btnRegis.setOnClickListener(this);

    }

    @Override
    public void onClick(View v) {

        switch (v.getId()){

            case R.id.btnLogin:
                if (txtUsername.getText().length() <= 0){
                    Message.alert("Harap isi Username", this);
                } else if (txtPassword.getText().length() <= 0) {
                    Message.alert("Harap isi Password", this);
                } else {

                }

        }

    }
}