import React, { useState } from "react";
import image1 from "../images/image1.png";

function MyCart_ProductCard() {
  const [productPiece, setProductPiece] = useState(1);
  return (
    <div
      className="myCart-product"
      style={{
        border: "1px solid gray",
        borderRadius: "12px",
        marginBottom: "1rem",
      }}
    >
      <div
        className="myCart-product-seller"
        style={{
          backgroundColor: "rgb(239, 239, 239)",
          padding: ".5rem",
          borderTopRightRadius: "12px",
          borderTopLeftRadius: "12px",
          borderBottom: "1px solid gray",
          boxShadow: "0 0 5px gray",
        }}
      >
        <p>
          Satıcı:{" "}
          <a
            style={{
              textDecoration: "underline",
              cursor: "pointer",
              color: "darkblue",
            }}
          >
            Take Hiq
          </a>
        </p>
      </div>
      <div style={{ display: "flex", alignItems: "center" }}>
        <img src={image1} style={{ width: "8rem", padding: "1rem" }}></img>
        <div
          style={{
            width: "100%",
            display: "flex",
            justifyContent: "space-between",
            alignItems: "center",
            padding: " 0 2rem",
          }}
        >
          <div>
            <p style={{ fontSize: "1rem" }}>
              <strong>Protein Ocean </strong> Gainer 5000gr
            </p>
            <p style={{ fontSize: ".8rem" }}>
              <span style={{ color: "green" }}>Hızlı Teslimat:</span> 2 gün
              içinde kargoda
            </p>
          </div>
          <div style={{ textAlign: "center" }}>
            <i
              style={{ fontSize: "1.2rem", cursor: "pointer" }}
              class="ri-checkbox-indeterminate-line"
              onClick={() => {
                if (productPiece === 1) {
                } else {
                  setProductPiece(productPiece - 1);
                }
              }}
            ></i>
            <p style={{ fontSize: "1.2rem" }}>{productPiece}</p>
            <i
              style={{ fontSize: "1.2rem", cursor: "pointer" }}
              class="ri-add-box-line"
              onClick={() => {
                if (productPiece === 11) {
                } else {
                  setProductPiece(productPiece + 1);
                }
              }}
            ></i>
          </div>
          <div>
            <p style={{ fontSize: "1rem" }}>₺ 199,00</p>
          </div>
        </div>
      </div>
    </div>
  );
}

export default MyCart_ProductCard;
