import React from "react";
import ProductCard from "../components/ProductCard";
import { Button } from "react-bootstrap";

function MyFavourites() {
  return (
    <div
      style={{ padding: "1rem 8rem", padding: "13rem", paddingBottom: "10rem" }}
    >
      <h2>imertak'ın Favorileri!</h2>
      <div
        style={{
          display: "flex",
          flexWrap: "wrap",
          justifyContent: "center",
          columnGap: "1.2rem",
          rowGap: "2rem",
          marginTop: "1rem",
        }}
      >
        <ProductCard></ProductCard>
        <ProductCard></ProductCard>
        <ProductCard></ProductCard>
        <ProductCard></ProductCard>
        <ProductCard></ProductCard>
        <ProductCard></ProductCard>
        <ProductCard></ProductCard>
      </div>
      <Button
        onClick={() => {
          window.location.href = "/sepetim";
        }}
        style={{
          cursor: "pointer",
          border: "none",
          width: "100%",
          padding: "2rem",
          color: "white",
          backgroundColor: "black",
          fontSize: "1.5rem",
          marginTop: "2rem",
        }}
      >
        Sepete Git
      </Button>
    </div>
  );
}

export default MyFavourites;
