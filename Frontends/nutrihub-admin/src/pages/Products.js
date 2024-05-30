import React, { useState } from "react";
import ProductCard from "../component/ProductCard";
import { Button, Form, Modal } from "react-bootstrap";
import "bootstrap/dist/css/bootstrap.min.css";

function Products() {
  const [show, setShow] = useState(false);

  const handleClose = () => setShow(false);
  const handleShow = () => setShow(true);

  return (
    <div
      style={{
        display: "flex",
        flexWrap: "wrap",
        rowGap: "2rem",
        columnGap: "1rem",
        padding: "2rem 6rem",
      }}
    >
      <Button
        variant="primary"
        onClick={handleShow}
        style={{ backgroundColor: "gray", border: "none", width: "15rem" }}
      >
        Ürün Ekle
      </Button>
      <Modal show={show} onHide={handleClose}>
        <Modal.Header closeButton>
          <Modal.Title>Ürün ekle</Modal.Title>
        </Modal.Header>
        <Modal.Body>
          <Form.Group controlId="formFileMultiple" className="mb-3">
            <Form.Label>Ürün Fotoğrafları</Form.Label>
            <Form.Control type="file" multiple />
          </Form.Group>
          <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
            <Form.Label>Ürün Adı</Form.Label>
            <Form.Control type="text" placeholder="" />
          </Form.Group>
          <div
            style={{ display: "flex", columnGap: "1rem", marginBottom: "1rem" }}
          >
            <Form.Select aria-label="Default select example">
              <option>Kategori</option>
              <option value="1">One</option>
              <option value="2">Two</option>
              <option value="3">Three</option>
            </Form.Select>
            <Form.Select aria-label="Default select example">
              <option>Alt Kategori</option>
              <option value="1">One</option>
              <option value="2">Two</option>
              <option value="3">Three</option>
            </Form.Select>
          </div>
          <Form.Group className="mb-3" controlId="exampleForm.ControlTextarea1">
            <Form.Label>Ürün Açıklaması</Form.Label>
            <Form.Control as="textarea" rows={3} />
          </Form.Group>
          <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
            <Form.Label>Ürün Stoğu</Form.Label>
            <Form.Control type="text" placeholder="" />
          </Form.Group>
        </Modal.Body>
        <Modal.Footer>
          <Button variant="secondary" onClick={handleClose}>
            Close
          </Button>
          <Button variant="primary" onClick={handleClose}>
            Save Changes
          </Button>
        </Modal.Footer>
      </Modal>
      <ProductCard />
      <ProductCard />
      <ProductCard />
      <ProductCard />
      <ProductCard />
      <ProductCard />
      <ProductCard />
      <ProductCard />
      <ProductCard />
    </div>
  );
}

export default Products;
