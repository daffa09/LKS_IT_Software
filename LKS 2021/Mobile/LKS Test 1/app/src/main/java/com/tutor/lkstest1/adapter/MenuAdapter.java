package com.tutor.lkstest1.adapter;

import android.content.Context;
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.Menu;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ImageButton;
import android.widget.TextView;

import androidx.recyclerview.widget.RecyclerView;

import com.tutor.lkstest1.DetailMenuActivity;
import com.tutor.lkstest1.R;

import java.util.List;

public class MenuAdapter extends RecyclerView.Adapter<MenuAdapter.ViewHolder> {

    private List<Menu> mData;
    private LayoutInflater mInflater;
    private AdapterView.OnItemClickListener mClickListener;

    //data is passed into the constructor
    public MenuAdapter(Context context, List<Menu> data){
        Log.d("MenuAdapter", String.valueOf(data.size()));
        this.mInflater = LayoutInflater.from(context);
        this.mData = data;
    }

    // inflates the row layout from xml when needed
    @Override
    public MenuAdapter.ViewHolder onCreateViewHolder(ViewGroup parent, int viewType){
        View view = mInflater.inflate(R.layout.activity_detail_menu, parent, false);
        return new RecyclerView.ViewHolder(view);
    }

    // binds the data to the textview in each row
    @Override
    public void onBindViewHolder(ViewHolder holder, final int position){
        final Menu menu = mData.get(position);
        final DetailMenuActivity detailMenuActivity = new DetailMenuActivity();
        holder.lblName.setText(Menu.getName());
        holder.lblDesc.setText(Menu.getDescription());
        holder.lblPrice.setText(String.valueOf(menu.getPrice()));

        // set onClickListerner pada view tvTitle (TextView)
        holder.btnEdit.setOnClickListener(new View.OnClickListener(){

            @Override
            public void onCLick(View v){
                Bundle = new Bundle();
                bundle.putString("id", String.valueOf(menu.getId()));
                bundle.putString("name", String.valueOf(menu.getName()));
                bundle.putString("desc", String.valueOf(menu.getDescription()));
                bundle.putString("price", String.valueOf(menu.getPrice()));
                Intent intent = new Intent(App.getContext(), MenuAksiAktivity.class);
                intent.putExtra(bundle);
                v.getContext().startActivity(intent);
            }

        });

        holder.btnDelete.setOnclickListener(new View.OnClickListener(){
           @Override
           public void onClick(View v){
               DetailMenuActivity.deleteMenu(String.valueOf(menu.getId()));
               mData.remove(position);
               notifyItemRemoved(position);
               notifyDataSetChanged();

           }
        });


    }

    // total number of rows
    @Override
    public int getItemCount(){ return mData.size(); }


    // stores and recycles views as they are scrolled off screen
    public class ViewHolder extends RecyclerView.ViewHolder implements  View.OnClickListener{
        TextView lblName, lblDesc, lblPrice;
        ImageButton btnEdit, btnDelete;

        ViewHolder(View itemView){

            super(ItemView);
            btnEdit = itemView.findViewById(R.id.btnEdit);
            btnDelete = itemView.findViewById(R.id.btnDelete);
            lblName = itemView.findViewById(R.id.lblName);
            lblDesc = itemView.findViewById(R.id.lblDesc);
            lblPrice = itemView.findViewById(R.id.lblPrice);
            itemView.setOnClickListener(this);
        }

        @Override
        public void onClick(View view){
            Log.d("MenuAdapter", "MASUK3");
            if (mClickListener != null) mClickListener.onItemClick(view, getAdapterPosition());
        }
    }

    // convenience method for getting data at click position
    public int getItem(int id){
        Log.d("MenuAdapter", "MASUK5");
        return mData.get(id).getId();
    }

    // allows clicks events to be caught
    public void setOnclickListener(ItemClickListener itemClickListener){
        Log.d("MenuAdapter", "MASUK4");
        this.mClickListener = itemClickListener;
    }

    // parent activity will implement this method to respond to click events
    public interface ItemClickListener{
        void onItemCLick(View view, int position);
    }
}
