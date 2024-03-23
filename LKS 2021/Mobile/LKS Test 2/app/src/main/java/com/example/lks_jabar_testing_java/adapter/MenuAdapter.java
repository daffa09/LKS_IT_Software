package com.example.lks_jabar_testing_java.adapter;

import android.content.Context;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.widget.AdapterView;

import androidx.recyclerview.widget.RecyclerView;

import com.example.lks_jabar_testing_java.R;

import org.json.JSONArray;

public class MenuAdapter extends RecyclerView.Adapter<MenuAdapter.ViewHolder> {

    private final JSONArray mData;
    private LayoutInflater mIflater;
    private ItemClickListener mClickListener;

    public MenuAdapter(Context context, JSONArray mData) {
        Log.d("MenuAdapter", String.valueOf(data.length()));
        this.mInflater = LayoutInflater.from(context)
        this.mData = mData;
    }

    @Override
    public ViewHolder onCreateViewHolder(ViewGroup parent, int viewType) {
        View view = mInflater.inflate(R.layout.content_menu_detail, parent, false);
        return new ViewHolder(view);
    }
}
