<template>
  <div class="min-h-full">
    <BaseNavbar />
    <header class="bg-white shadow-sm">
      <div v-if="area && area.name" class="mx-auto max-w-7xl px-4 py-4 sm:px-6 lg:px-8">
        <h1 class="text-lg font-semibold leading-6 text-gray-900">{{ area.name }} - Details</h1>
      </div>
      <div v-else class="mx-auto max-w-7xl px-4 py-4 sm:px-6 lg:px-8">
        <h1 class="text-lg font-semibold leading-6 text-gray-900">Loading...</h1>
      </div>
    </header>
    <main>
      <div class="mx-auto max-w-7xl py-6 sm:px-6 lg:px-8">
        <div class="container mx-auto p-4">
          <div v-if="areaError" class="text-red-500">{{ areaError.message }}</div>
          <div v-else-if="area">
            <div class="flex flex-col md:flex-row gap-4">
              <!-- Left Box: Area Information -->
              <div class="bg-white rounded-lg shadow-lg p-6 flex-1">
                <div class="bg-gray-200 h-40 rounded-t-lg mb-4 flex items-center justify-center">
                  <span class="text-gray-500">Image Placeholder</span>
                </div>
                <div>
                  <h2 class="text-xl font-semibold mb-2">{{ area.name }}</h2>
                  <p class="text-gray-700"><strong>Capacity:</strong> {{ area.capacity }}</p>
                  <p class="text-gray-700 mt-2">{{ area.description }}</p>
                </div>
              </div>
              <!-- Right Box: Availability and Reservation -->
              <div class="bg-white rounded-lg shadow-lg p-6 flex-1">
                <h3 class="text-lg font-semibold mb-4">Availability</h3>
                <div class="flex flex-col space-y-2">
                  <div class="flex justify-between items-center">
                    <span>Date:</span>
                    <input type="date" v-model="selectedDate" class="border rounded-md p-2" @change="updateDayHeader" />
                  </div>
                  <div class="mt-4">
                    <h4 class="text-md font-semibold">{{ dayHeader }}</h4>
                    <div v-if="selectedDate" class="flex flex-wrap gap-2 mt-2">
                      <!-- Time slots -->
                      <button
                          v-for="slot in timeSlots"
                          :key="slot"
                          :disabled="isSlotReserved(slot)"
                          :class="{
                          'bg-gray-200': !isSlotReserved(slot) && selectedSlot !== slot,
                          'bg-purple-200': selectedSlot === slot,
                          'bg-red-200': isSlotReserved(slot)
                        }"
                          class="rounded-full px-4 py-2"
                          @click="selectSlot(slot)"
                      >
                        {{ slot }}
                      </button>
                    </div>
                    <div v-else class="text-gray-700">Please select a date to see available time slots.</div>
                  </div>
                  <button
                      class="bg-purple-500 text-white rounded-lg mt-4 px-4 py-2"
                      @click="openReservationModal"
                  >
                    Reserve Area
                  </button>
                  <div v-if="reserveError" class="text-red-500 mt-2">{{ reserveError }}</div>
                </div>
              </div>
            </div>
          </div>
          <div v-else>
            <div class="text-gray-700">Loading area details...</div>
          </div>
        </div>
      </div>
    </main>
    <ReservationFormModal
        :open="isReservationModalOpen"
        @close="isReservationModalOpen = false"
        :selectedDate="selectedDate"
        :selectedSlot="selectedSlot"
        :areaId="Number(route.params.areaId)"
        :customerId="4"
    />
  </div>
</template>

<script setup>
import { ref, onMounted, watch } from 'vue';
import { useRoute } from 'vue-router';
import BaseNavbar from '../components/BaseNavbar.vue';
import { useAreas } from '../composables/useAreas';
import ReservationFormModal from '../components/ReservationFormModal.vue';
import { useReservations } from '../composables/useReservations';

const route = useRoute();
const areaError = ref(null);
const reserveError = ref(null);

const { fetchArea, area } = useAreas();
const { getReservationsByAreaAndDate } = useReservations();

const timeSlots = ref([
  '09:00 - 10:00', '10:00 - 11:00', '11:00 - 12:00', '12:00 - 13:00',
  '13:00 - 14:00', '14:00 - 15:00', '15:00 - 16:00'
]);

const selectedDate = ref('');
const selectedSlot = ref(null);
const dayHeader = ref('');
const isReservationModalOpen = ref(false);

const updateDayHeader = () => {
  const date = new Date(selectedDate.value);
  dayHeader.value = date.toLocaleDateString('en-US', { weekday: 'long', year: 'numeric', month: 'long', day: 'numeric' });
};

const selectSlot = (slot) => {
  if (!isSlotReserved(slot)) {
    selectedSlot.value = slot;
  }
};

const openReservationModal = () => {
  reserveError.value = null;
  if (!selectedDate.value) {
    reserveError.value = 'Please select a date.';
    return;
  }
  if (!selectedSlot.value) {
    reserveError.value = 'Please select a time slot.';
    return;
  }
  isReservationModalOpen.value = true;
};

const reservedSlots = ref([]);

const isSlotReserved = (slot) => {
  return reservedSlots.value.includes(slot);
};

const fetchReservedSlots = async () => {
  if (!selectedDate.value) return;
  reservedSlots.value = [];
  try {
    const reservations = await getReservationsByAreaAndDate(Number(route.params.areaId), selectedDate.value);
    reservedSlots.value = reservations.map(res => {
      const from = new Date(res.reservationFrom).toLocaleTimeString('pl-PL', { hour: '2-digit', minute: '2-digit' });
      const to = new Date(res.reservationTo).toLocaleTimeString('pl-PL', { hour: '2-digit', minute: '2-digit' });
      return `${from} - ${to}`;
    });
  } catch (err) {
    console.error('Failed to fetch reserved slots', err);
  }
};

watch(selectedDate, fetchReservedSlots);

const fetchAreaDetails = async () => {
  try {
    await fetchArea(route.params.areaId);
  } catch (err) {
    areaError.value = err;
  }
};

onMounted(fetchAreaDetails);
</script>
