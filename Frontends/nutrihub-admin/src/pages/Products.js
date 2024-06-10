import React, { useState } from "react";
import { Button } from "react-bootstrap";
import ProductModal from "../components/Product/ProductModal";
import ProductsTable from "../components/Product/ProductsTable";

function Products() {
  const [selectedProduct, setSelectedProduct] = useState(null);
  const [showProductModal, setShowProductModal] = useState(false);

  const handleShowProductModal = (product) => {
    setSelectedProduct(product);
    setShowProductModal(true);
  };

  const handleHideProductModal = () => {
    setSelectedProduct(null);
    setShowProductModal(false);
  };

  return (
    <div style={{ padding: "2rem 6rem" }}>
      <div
        style={{
          display: "flex",
          justifyContent: "flex-start", // Butonu sola hizalayacak
          marginBottom: "1rem",
        }}
      >
        <Button
          variant="primary"
          onClick={() => handleShowProductModal(null)}
          style={{ backgroundColor: "green", border: "none", width: "15rem" }}
        >
          Ürün Ekle
        </Button>
      </div>

      {showProductModal && (
        <ProductModal
          product={selectedProduct}
          onClose={handleHideProductModal}
        />
      )}

      <ProductsTable onEdit={handleShowProductModal} />
    </div>
  );
}

export default Products;
