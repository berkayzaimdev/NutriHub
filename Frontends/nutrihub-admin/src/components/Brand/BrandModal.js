import React, { useState, useEffect } from "react";
import { Button, Form, Modal } from "react-bootstrap";
import "bootstrap/dist/css/bootstrap.min.css";
import { API_BASE_URL } from "../../config";
import axios from "axios";

const BrandModal = ({ brand, onClose }) => {
  const [name, setName] = useState("");
  const [description, setDescription] = useState("");
  const [imageFile, setImageFile] = useState(null);
  const [imageUrl, setImageUrl] = useState("");

  useEffect(() => {
    if (brand) {
      setName(brand.name);
      setDescription(brand.description);
      setImageUrl(brand.imageUrl);
    } else {
      setName("");
      setDescription("");
      setImageUrl("");
    }
  }, [brand]);

  const handleSubmit = () => {
    const formData = new FormData();
    formData.append("Name", name);
    formData.append("Description", description);
    if (imageFile) {
      formData.append("Image", imageFile);
    }

    if (brand && brand.id) {
      axios
        .put(
          `${API_BASE_URL}/api/Brands`,
          JSON.stringify({
            id: brand.id,
            name,
            description,
            imageUrl: "123",
          }),
          {
            headers: {
              "Content-Type": "application/json",
            },
          }
        )
        .then(() => {
          console.log("success");
          window.location.reload();
        })
        .catch((error) => {
          console.error("Error adding product:", error);
        });
    } else {
      console.log(
        JSON.stringify({
          name,
          description,
          imageUrl: "123",
        })
      );

      axios
        .post(
          `${API_BASE_URL}/api/Brands`,
          JSON.stringify({
            name,
            description,
            imageUrl: "123",
          }),
          {
            headers: {
              "Content-Type": "application/json",
            },
          }
        )
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
        <Modal.Title>{brand ? "Markayı Düzenle" : "Marka Ekle"}</Modal.Title>
      </Modal.Header>
      <Modal.Body>
        <Form>
          <Form.Group controlId="formFileMultiple" className="mb-3">
            <Form.Label>Marka Görseli</Form.Label>
            <Form.Control
              type="file"
              multiple
              onChange={(e) => setImageFile(e.target.files[0])}
            />
          </Form.Group>
          <Form.Group className="mb-3" controlId="exampleForm.ControlInput1">
            <Form.Label>Marka Adı</Form.Label>
            <Form.Control
              type="text"
              value={name}
              onChange={(e) => setName(e.target.value)}
            />
          </Form.Group>
          <Form.Group className="mb-3" controlId="exampleForm.ControlTextarea1">
            <Form.Label>Marka Açıklaması</Form.Label>
            <Form.Control
              as="textarea"
              rows={3}
              value={description}
              onChange={(e) => setDescription(e.target.value)}
            />
          </Form.Group>
        </Form>
      </Modal.Body>
      <Modal.Footer>
        <Button variant="secondary" onClick={onClose}>
          Kapat
        </Button>
        <Button variant="primary" onClick={handleSubmit}>
          {brand ? "Güncelle" : "Ekle"}
        </Button>
      </Modal.Footer>
    </Modal>
  );
};

export default BrandModal;
