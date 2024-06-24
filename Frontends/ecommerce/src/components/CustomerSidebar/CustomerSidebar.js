import React from "react";
import { Link } from "react-router-dom";
import "./CustomerSidebar.css";

function CustomerSidebar() {
  return (
    <div className="sidebar">
      <h2>Hesabım</h2>
      <ul>
        <li>
          <Link to="/customer/orders">Siparişlerim</Link>
        </li>
        <li>
          <Link to="/customer/user-info">Kullanıcı Bilgilerim</Link>
        </li>
        <li>
          <Link to="/saved-cards">Kayıtlı Kartlarım</Link>
        </li>
        <li>
          <Link to="/customer/addresses">Adreslerim</Link>
        </li>
        <li>
          <Link to="/customer/changepassword">Şifre Değiştir</Link>
        </li>
        <li>
          <Link to="/customer/points">Puanlarım</Link>
        </li>
        <li>
          <Link to="/customer/favourites">Favorilerim</Link>
        </li>
        <li>
          <Link to="/customer/notify-when-available">Gelince Haber Ver</Link>
        </li>
      </ul>
    </div>
  );
}

export default CustomerSidebar;
