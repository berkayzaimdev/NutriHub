import React, { useState, useEffect } from "react";
import { Button, Form, Modal } from "react-bootstrap";
import "bootstrap/dist/css/bootstrap.min.css";
import CategorySelector from "./CategorySelector";
import BrandSelector from "./BrandSelector";
import { API_BASE_URL } from "../../config";

const ProductModal = ({ product, onClose }) => {
  const [name, setName] = useState("");
  const [description, setDescription] = useState("");
  const [imageFile, setImageFile] = useState(null);
  const [imageUrl, setImageUrl] = useState("");
  const [price, setPrice] = useState(0);
  const [stock, setStock] = useState(0);
  const [brandId, setBrandId] = useState(0);
  const [categoryId, setCategoryId] = useState(0);
  const [subcategoryId, setSubcategoryId] = useState(0);

  useEffect(() => {
    if (product) {
      setName(product.name);
      setDescription(product.description);
      setImageUrl(product.imageUrl);
      setPrice(product.price);
      setStock(product.stock);
      setBrandId(product.brandId);
      setCategoryId(product.categoryId);
      setSubcategoryId(product.subcategoryId);
    } else {
      setName("");
      setDescription("");
      setImageUrl("");
      setPrice(0);
      setStock(0);
      setBrandId(0);
      setCategoryId(0);
      setSubcategoryId(0);
    }
  }, [product]);

  const handleSubmit = () => {
    const formData = new FormData();
    formData.append("Name", name);
    formData.append("Description", description);
    formData.append("Price", price);
    formData.append("Stock", stock);
    formData.append("BrandId", brandId);
    formData.append("CategoryId", categoryId);
    formData.append("SubcategoryId", subcategoryId);
    if (imageFile) {
      formData.append("Image", imageFile);
    }

    for (let [key, value] of formData.entries()) {
      console.log(key, value);
    }

    if (product && product.id) {
      console.log(
        JSON.stringify({
          id: product.id,
          name,
          description,
          imageUrl: "",
          price,
          stock,
          brandId,
          categoryId,
          subcategoryId,
        })
      );
      fetch(`${API_BASE_URL}/api/Products`, {
        method: "PUT",
        body: JSON.stringify({
          id: product.id,
          name,
          description,
          imageUrl: "",
          price,
          stock,
          brandId,
          categoryId,
          subcategoryId,
        }),
        headers: {
          "Content-Type": "application/json",
        },
      })
        .then(() => {
          window.location.reload();
        })
        .catch((error) => {
          console.error("Error updating product:", error);
        });
    } else {
      fetch(`${API_BASE_URL}/api/Products`, {
        method: "POST",
        body: formData,
      })
        .then(() => {
          window.location.reload();
        })
        .catch((error) => {
          console.error("Error adding product:", error);
        });
    }

    window.location.reload();
  };

  return (
    <Modal show={true} onHide={onClose}>
      <Modal.Header closeButton>
        <Modal.Title>{product ? "Ürünü Düzenle" : "Ürün Ekle"}</Modal.Title>
      </Modal.Header>
      <Modal.Body>
        <Form>
          <Form.Group controlId="formFileMultiple" className="mb-3">
            <Form.Label>Ürün Görseli</Form.Label>
            <Form.Control
              type="file"
              multiple
              onChange={(e) => setImageFile(e.target.files[0])}
            />
          </Form.Group>
          <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
            <Form.Label>Ürün Adı</Form.Label>
            <Form.Control
              type="text"
              value={name}
              onChange={(e) => setName(e.target.value)}
            />
          </Form.Group>
          <Form.Group className="mb-3" controlId="exampleForm.ControlTextarea1">
            <Form.Label>Ürün Açıklaması</Form.Label>
            <Form.Control
              as="textarea"
              rows={3}
              value={description}
              onChange={(e) => setDescription(e.target.value)}
            />
          </Form.Group>
          <CategorySelector
            value={{ categoryId, subcategoryId }}
            setCategoryId={setCategoryId}
            setSubcategoryId={setSubcategoryId}
          />
          <BrandSelector value={brandId} setBrandId={setBrandId} />
          <Form.Group className="mb-3" controlId="exampleForm.ControlInput2">
            <Form.Label>Fiyat</Form.Label>
            <Form.Control
              type="number"
              value={price}
              onChange={(e) => setPrice(Number(e.target.value))}
            />
          </Form.Group>
          <Form.Group className="mb-3" controlId="exampleForm.ControlInput3">
            <Form.Label>Stok</Form.Label>
            <Form.Control
              type="number"
              value={stock}
              onChange={(e) => setStock(Number(e.target.value))}
            />
          </Form.Group>
        </Form>
      </Modal.Body>
      <Modal.Footer>
        <Button variant="secondary" onClick={onClose}>
          Kapat
        </Button>
        <Button variant="primary" onClick={handleSubmit}>
          {product ? "Güncelle" : "Ekle"}
        </Button>
      </Modal.Footer>
    </Modal>
  );
};

export default ProductModal;
