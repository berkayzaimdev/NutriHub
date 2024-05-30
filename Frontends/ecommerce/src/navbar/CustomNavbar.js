import React, { useState } from "react";
import "../navbar/CustomNavbar.css";
import logo from "../images/nutrihub_logo2.jpg";

function CustomNavbar() {
  const [showMenu, setShowMenu] = useState(false);
  const [showSearchBar, setShowSearchBar] = useState(false);
  return (
    <div>
      <header className="header">
        <nav className="navbar">
          <div className="navbar-logo">
            <a
              className="navbar-logo-text"
              href="/"
              style={{ display: "flex", alignItems: "center" }}
            >
              <img
                src={logo}
                style={{ width: "100px", marginRight: ".7rem" }}
              ></img>
              <span>NUTRI HUB</span>
            </a>
          </div>
          <div className="navbar-links">
            <ul className="navbar-link-list">
              <li className="navbar-item">
                <a className="navbar-link" href="/">
                  Anasayfa
                </a>
              </li>
              <li className="navbar-item">
                <a className="navbar-link" href="/urunler">
                  Ürünler
                </a>
              </li>
              <li className="navbar-item">
                <a className="navbar-link" href="/blog">
                  Blog
                </a>
              </li>
              <li className="navbar-item">
                <a className="navbar-link" href="/satis" target="_blank">
                  Satış
                </a>
              </li>
            </ul>
          </div>
          <div className="navbar-profile">
            <a
              className="navbar-profile-link"
              onClick={() => {
                setShowMenu(false);
                setShowSearchBar(!showSearchBar);
              }}
            >
              <i class="ri-search-line"></i>
            </a>

            <a className="navbar-profile-link" href="/profilim">
              <i className="ri-user-line"></i>
            </a>

            <a className="navbar-profile-link" href="/sepetim">
              <i className="ri-shopping-cart-2-line"></i>
            </a>
            <a className="navbar-profile-link" href="/favorilerim">
              <i className="ri-heart-2-line"></i>
            </a>

            <a
              className="navbar-profile-link"
              onClick={() => {
                setShowMenu(!showMenu);
                setShowSearchBar(false);
              }}
            >
              <i class="ri-menu-line"></i>
            </a>
          </div>

          <div
            className="navbar-categories"
            id={showMenu ? "active-categories-menu" : ""}
          >
            <ul className="navbar-categories-list">
              <li className="navbar-category-item">
                <a href="/protein-tozu">Protein Tozu</a>
              </li>
              <li className="navbar-category-item">
                <a href="amino-asit">Amino Asit</a>
              </li>
              <li className="navbar-category-item">
                <a href="/kreatin">Kreatin</a>
              </li>
              <li className="navbar-category-item">
                <a href="kilo-ve-hacim">Kilo ve Hacim</a>
              </li>
              <li className="navbar-category-item">
                <a href="/atistirmaliklar">Sağlıklı Atıştırmalıklar</a>
              </li>
              <li className="navbar-category-item">
                <a href="/aksesuarlar">Aksesuarlar</a>
              </li>
            </ul>
          </div>
          <div
            className="navbar-search-bar"
            id={showSearchBar ? "active-search-bar" : ""}
          >
            <i className="ri-search-line"></i>
            <input
              className="navbar-search-bar-input"
              type="text"
              placeholder="Arama Yap"
            />
            <i
              className="ri-close-line"
              onClick={() => {
                setShowSearchBar(false);
              }}
            ></i>
          </div>
        </nav>
      </header>
    </div>
  );
}

export default CustomNavbar;
