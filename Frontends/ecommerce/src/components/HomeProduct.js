import React from "react";
import image1 from "../images/image1.png";
import image2 from "../images/image2.png";

function HomeProduct() {
  return (
    <div
      className="home-product-card"
      style={{ padding: "10px", border: ".1rem solid black" }}
    >
      <div style={{ display: "flex", justifyContent: "center" }}>
        <a href="/urun">
          <img src={image2} style={{ width: "200px", cursor: "pointer" }}></img>
        </a>

        <i
          className="ri-add-circle-line"
          style={{
            position: "relative",
            fontSize: "28px",
            cursor: "pointer",
          }}
        ></i>
      </div>

      <div style={{ marginTop: "1.5rem", borderTop: "1px solid black" }}></div>
      <a href="/urun">
        <p
          style={{
            marginTop: "1rem",
            textAlign: "left",
            marginBottom: "1rem",
            cursor: "pointer",
          }}
        >
          Progainer Çikolata 5000 Gr
        </p>
      </a>
      <div
        style={{
          display: "flex",
          justifyContent: "space-between",
        }}
      >
        <p style={{ cursor: "pointer" }}>
          <strong>599,00 TL</strong>
        </p>
        <p style={{ color: "orange" }}>
          <i className="ri-star-fill"></i>
          <i className="ri-star-fill"></i>
          <i className="ri-star-fill"></i>
          <i className="ri-star-fill"></i>
          <i className="ri-star-fill"></i>
        </p>
      </div>
    </div>
  );
}

export default HomeProduct;
