import React, { useEffect, useState } from "react";
import {
  Button,
  ListGroup,
  Collapse,
  Form,
  InputGroup,
  Row,
  Col,
  Modal,
} from "react-bootstrap";
import { API_BASE_URL } from "../../config";
import "bootstrap/dist/css/bootstrap.min.css";
import "./Categories.css";
import swal from "sweetalert";

function Categories() {
  const [categories, setCategories] = useState([]);
  const [newCategoryName, setNewCategoryName] = useState("");
  const [newSubcategoryName, setNewSubcategoryName] = useState("");
  const [openCategoryId, setOpenCategoryId] = useState(null);

  const [showAddModal, setShowAddModal] = useState(false);
  const [showEditModal, setShowEditModal] = useState(false);

  const [currentItem, setCurrentItem] = useState(null);
  const [currentItemName, setCurrentItemName] = useState("");
  const [currentItemDescription, setCurrentItemDescription] = useState("");

  const [newItem, setNewItem] = useState(null);
  const [newItemType, setNewItemType] = useState("");
  const [newItemCategoryId, setNewItemCategoryId] = useState(0);
  const [newItemName, setNewItemName] = useState("");
  const [newItemDescription, setNewItemDescription] = useState("");

  useEffect(() => {
    fetchCategories();
  });

  const fetchCategories = async () => {
    fetch(`${API_BASE_URL}/api/Categories/GetCategoriesWithSubcategories`)
      .then((response) => response.json())
      .then((data) => setCategories(data));
  };

  const showAddNewItem = (type, id) => {
    setNewItemType(type);
    setNewItemCategoryId(id);
    setShowAddModal(true);
  };

  const handleAddNewItem = () => {
    if (newItemType === "category") {
      handleAddCategory();
    } else {
      handleAddSubcategory(newItemCategoryId);
    }
  };

  const handleAddCategory = () => {
    console.log(
      JSON.stringify({
        name: newCategoryName,
        description: "",
        imageUrl: "",
      })
    );

    fetch(`${API_BASE_URL}/api/Categories`, {
      method: "POST",
      body: JSON.stringify({
        name: newItemName,
        description: newItemDescription,
        imageUrl: "asdas",
      }),
      headers: {
        "Content-Type": "application/json",
      },
    })
      .then((response) => {
        if (!response.ok) {
          throw new Error(`HTTP error! status: ${response.status}`);
        }
        return response.text();
      })
      .then((text) => {
        if (text) {
          try {
            const data = JSON.parse(text);
            console.log("Category added:", data);
          } catch (error) {
            console.error("Error parsing JSON:", error);
          }
        } else {
          console.log("No content in response");
        }
        window.location.reload();
      })
      .catch((error) => {
        console.error("Error adding category:", error);
      });
  };

  const handleAddSubcategory = async (categoryId) => {
    console.log(
      JSON.stringify({
        categoryId: categoryId,
        name: newItemName,
        description: newItemDescription,
        imageUrl: "asdas",
      })
    );

    fetch(`${API_BASE_URL}/api/Subcategories`, {
      method: "POST",
      body: JSON.stringify({
        categoryId: categoryId,
        name: newSubcategoryName,
        description: "",
        imageUrl: "",
      }),
      headers: {
        "Content-Type": "application/json",
      },
    });

    window.location.reload();
  };

  const handleEditItem = (item, type) => {
    setCurrentItem({ ...item, type });
    setCurrentItemName(item.name);
    setCurrentItemDescription(item.description);
    console.log("item: " + JSON.stringify(item));
    setShowEditModal(true);
  };

  const handleSaveEdit = () => {
    if (currentItem?.type === "category") {
      handleSaveCategory();
    } else {
      handleSaveSubcategory();
    }
  };

  const handleSaveCategory = () => {
    console.log(
      JSON.stringify({
        id: currentItem.id,
        name: currentItemName,
        description: currentItemDescription,
        imageUrl: "test",
      })
    );

    fetch(`${API_BASE_URL}/api/Categories`, {
      method: "PUT",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({
        id: currentItem.id,
        name: currentItemName,
        description: currentItemDescription,
        imageUrl: "test",
      }),
    })
      .then((response) => {
        if (!response.ok) {
          throw new Error(`HTTP error! status: ${response.status}`);
        }
        return response.text();
      })
      .then((message) => {
        swal("İşlem başarılı!", message, "success").then(() => {
          window.location.reload();
        });
      })
      .catch((error) => {
        console.error("Error updating item:", error);
        swal("Error", "There was an error updating the item", "error");
      });
  };

  const handleSaveSubcategory = () => {
    console.log(
      JSON.stringify({
        id: currentItem.id,
        categoryId: currentItem.categoryId,
        name: currentItemName,
        description: currentItemDescription,
        imageUrl: "sdgdsg",
      })
    );
    fetch(`${API_BASE_URL}/api/Subcategories`, {
      method: "PUT",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify({
        id: currentItem.id,
        categoryId: currentItem.categoryId,
        name: currentItemName,
        description: currentItemDescription,
        imageUrl: "test",
      }),
    })
      .then((response) => {
        if (!response.ok) {
          throw new Error(`HTTP error! status: ${response.status}`);
        }
        return response.text();
      })
      .then((message) => {
        swal("İşlem başarılı!", message, "success").then(() => {
          window.location.reload();
        });
      })
      .catch((error) => {
        console.error("Error updating item:", error);
        swal("Error", "There was an error updating the item", "error");
      });
  };

  const handleDeleteCategory = (categoryId) => {
    swal({
      title: "Emin misiniz?",
      text: "Silinen kategoriyi tekrar geri alamazsınız!",
      icon: "warning",
      buttons: true,
      dangerMode: true,
    }).then((willDelete) => {
      if (willDelete) {
        fetch(`${API_BASE_URL}/api/Categories`, {
          method: "DELETE",
          body: JSON.stringify({
            id: categoryId,
          }),
          headers: {
            "Content-Type": "application/json",
          },
        })
          .then((response) => {
            if (!response.ok) {
              throw new Error(`HTTP error! status: ${response.status}`);
            }
            window.location.reload();
          })
          .catch((error) => {
            console.error("Error deleting category:", error);
            swal("Error deleting category!", {
              icon: "error",
            });
          });
      }
    });
  };

  const handleDeleteSubcategory = (subCategoryId) => {
    swal({
      title: "Emin misiniz?",
      text: "Silinen alt kategoriyi tekrar geri alamazsınız!",
      icon: "warning",
      buttons: true,
      dangerMode: true,
    }).then((willDelete) => {
      if (willDelete) {
        fetch(`${API_BASE_URL}/api/Subcategories`, {
          method: "DELETE",
          body: JSON.stringify({
            id: subCategoryId,
          }),
          headers: {
            "Content-Type": "application/json",
          },
        })
          .then((response) => {
            if (!response.ok) {
              throw new Error(`HTTP error! status: ${response.status}`);
            }
            window.location.reload();
          })
          .catch((error) => {
            console.error("Error deleting subcategory:", error);
            swal("Error deleting subcategory!", {
              icon: "error",
            });
          });
      }
    });
  };

  const handleFileUpload = (e) => {
    const file = e.target.files[0];
    if (file) {
      // Dosyayı burada işleyebilirsiniz
      console.log(file);
    }
  };

  return (
    <div style={{ padding: "2rem 6rem" }}>
      <div
        style={{
          display: "flex",
          justifyContent: "flex-start",
          marginBottom: "1rem",
        }}
      >
        <Button
          variant="primary"
          style={{ backgroundColor: "green", border: "none", width: "15rem" }}
          onClick={() => showAddNewItem("category")}
        >
          Kategori Ekle
        </Button>
      </div>
      <ListGroup className="striped">
        {categories.map((category) => (
          <ListGroup.Item key={category.id}>
            <div className="d-flex justify-content-between align-items-center">
              <div className="d-flex align-items-center">
                <Button
                  variant="link"
                  onClick={() =>
                    setOpenCategoryId(
                      openCategoryId === category.id ? null : category.id
                    )
                  }
                  aria-controls={`subcategory-collapse-${category.id}`}
                  aria-expanded={openCategoryId === category.id}
                >
                  {openCategoryId === category.id ? "-" : "+"}
                </Button>
                <span className="ml-2">{category.name}</span>
              </div>
              <div>
                <Button
                  variant="warning"
                  size="sm"
                  className="mr-3"
                  onClick={() => handleEditItem(category, "category")}
                >
                  Güncelle
                </Button>
                <Button
                  variant="danger"
                  size="sm"
                  onClick={() => handleDeleteCategory(category.id)}
                >
                  Sil
                </Button>
              </div>
            </div>
            <Collapse in={openCategoryId === category.id}>
              <div id={`subcategory-collapse-${category.id}`}>
                <ListGroup className="mt-3">
                  {category.subcategories.map((sub) => (
                    <ListGroup.Item key={sub.id}>
                      <div className="d-flex justify-content-between align-items-center">
                        <span>{sub.name}</span>
                        <div>
                          <Button
                            variant="warning"
                            size="sm"
                            className="mr-3"
                            onClick={() => handleEditItem(sub, "subcategory")}
                          >
                            Güncelle
                          </Button>
                          <Button
                            variant="danger"
                            size="sm"
                            onClick={() => handleDeleteSubcategory(sub.id)}
                          >
                            Sil
                          </Button>
                        </div>
                      </div>
                    </ListGroup.Item>
                  ))}
                  <ListGroup.Item>
                    <Row>
                      <Col xs={12} md={6}>
                        <Button
                          variant="success"
                          onClick={() =>
                            showAddNewItem("subCategory", category.id)
                          }
                        >
                          Alt Kategori Ekle
                        </Button>
                      </Col>
                    </Row>
                  </ListGroup.Item>
                </ListGroup>
              </div>
            </Collapse>
          </ListGroup.Item>
        ))}
      </ListGroup>

      <Modal show={showAddModal} onHide={() => setShowAddModal(false)}>
        <Modal.Header closeButton>
          <Modal.Title>
            {newItemType === "category" ? "Kategori" : "Alt Kategori"} Ekle
          </Modal.Title>
        </Modal.Header>

        <Modal.Body>
          <Form.Group>
            <Form.Label>
              {newItemType === "category" ? "Kategori" : "Alt Kategori"} Adı
            </Form.Label>
            <Form.Control
              type="text"
              value={newItemName}
              onChange={(e) => setNewItemName(e.target.value)}
            />
            <Form.Label>Açıklaması</Form.Label>
            <Form.Control
              as="textarea"
              value={newItemDescription}
              onChange={(e) => setNewItemDescription(e.target.value)}
            />
            <Form.Label>Görsel Yükle</Form.Label>
            <Form.Control
              type="file"
              accept="image/*"
              onChange={(e) => handleFileUpload(e)}
            />
          </Form.Group>
        </Modal.Body>

        <Modal.Footer>
          <Button variant="secondary" onClick={() => setShowAddModal(false)}>
            Kapat
          </Button>
          <Button variant="warning" onClick={handleAddNewItem} className="ml-2">
            Ekle
          </Button>
        </Modal.Footer>
      </Modal>

      <Modal show={showEditModal} onHide={() => setShowEditModal(false)}>
        <Modal.Header closeButton>
          <Modal.Title>
            {currentItem?.type === "category" ? "Kategori" : "Alt Kategori"}{" "}
            Güncelle
          </Modal.Title>
        </Modal.Header>

        <Modal.Body>
          <Form.Group>
            <Form.Label>
              {currentItem?.type === "category" ? "Kategori" : "Alt Kategori"}{" "}
              Adı
            </Form.Label>
            <Form.Control
              type="text"
              value={currentItemName}
              onChange={(e) => setCurrentItemName(e.target.value)}
            />
            <Form.Label>Açıklaması</Form.Label>
            <Form.Control
              as="textarea"
              value={currentItemDescription}
              onChange={(e) => setCurrentItemDescription(e.target.value)}
            />
            <Form.Label>Görsel Yükle</Form.Label>
            <Form.Control
              type="file"
              accept="image/*"
              onChange={(e) => handleFileUpload(e)}
            />
          </Form.Group>
        </Modal.Body>

        <Modal.Footer>
          <Button variant="secondary" onClick={() => setShowEditModal(false)}>
            Kapat
          </Button>
          <Button variant="warning" onClick={handleSaveEdit} className="ml-2">
            Güncelle
          </Button>
        </Modal.Footer>
      </Modal>
    </div>
  );
}

export default Categories;
