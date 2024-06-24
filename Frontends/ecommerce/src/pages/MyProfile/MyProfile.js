import React from "react";
import { FaRegTrashAlt } from "react-icons/fa";
import "./MyProfile.css";
import CustomerSidebar from "../../components/CustomerSidebar/CustomerSidebar";

const MyProfile = () => {
  return (
    <div className="my-profile">
      <CustomerSidebar />
      <div className="content">
        <h2>Favorilerim</h2>
        <table className="favorites-table">
          <thead>
            <tr>
              <th>Sil</th>
              <th>Görsel</th>
              <th>Ürün Adı</th>
              <th>Fiyat</th>
              <th></th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td>
                <button className="delete-button">
                  <FaRegTrashAlt />
                </button>
              </td>
              <td></td>
              <td>Supplementler.com Whey Protein 1000 Gr</td>
              <td>999,00 TL</td>
              <td>
                <button className="add-to-cart-button">SEPETE EKLE</button>
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
  );
};

export default MyProfile;
