import React from "react";
import image2 from "../images/image2.png";

function ProductCard({ product }) {
    return (
        <div
            className="home-product-card"
            style={{ padding: "10px", border: ".1rem solid black" }}
            onClick={() => {
                window.location.href = "/urun"; // URL stringini do�ru �ekilde atama
            }}
        >
            <div style={{ display: "flex", justifyContent: "center" }}>
                <img src={image2} style={{ width: "175px", cursor: "pointer" }}></img>
                <i
                    className="ri-add-circle-line"
                    style={{
                        position: "relative",
                        fontSize: "20px",
                        cursor: "pointer",
                    }}
                ></i>
            </div>

            <div style={{ marginTop: "1.5rem", borderTop: "1px solid black" }}></div>
            <p
                style={{
                    marginTop: "1rem",
                    textAlign: "left",
                    marginBottom: "1rem",
                    cursor: "pointer",
                    fontSize: "15px",
                }}
            >
                { product.name }
            </p>
            <div
                style={{
                    display: "flex",
                    justifyContent: "space-between",
                }}
            >
                <p style={{ cursor: "pointer", fontSize: "14px" }}>
                    <strong>{ product.price } TL</strong>
                </p>
                <p style={{ color: "orange", fontSize: "12px" }}>
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

export default ProductCard;
