<template>
  <TransitionRoot as="template" :show="open">
    <Dialog class="relative z-10" @close="closeModal">
      <TransitionChild
          as="template"
          enter="ease-out duration-300"
          enter-from="opacity-0"
          enter-to="opacity-100"
          leave="ease-in duration-200"
          leave-from="opacity-100"
          leave-to="opacity-0"
      >
        <div class="fixed inset-0 bg-gray-500 bg-opacity-75 transition-opacity" />
      </TransitionChild>

      <div class="fixed inset-0 z-10 w-screen overflow-y-auto">
        <div class="flex min-h-full items-end justify-center p-4 text-center sm:items-center sm:p-0">
          <TransitionChild
              as="template"
              enter="ease-out duration-300"
              enter-from="opacity-0 translate-y-4 sm:translate-y-0 sm:scale-95"
              enter-to="opacity-100 translate-y-0 sm:scale-100"
              leave="ease-in duration-200"
              leave-from="opacity-100 translate-y-0 sm:scale-100"
              leave-to="opacity-0 translate-y-4 sm:translate-y-0 sm:scale-95"
          >
            <DialogPanel class="relative transform overflow-hidden rounded-lg bg-white px-4 pb-4 pt-5 text-left shadow-xl transition-all sm:my-8 sm:w-full sm:max-w-sm sm:p-6">
              <div v-if="!reservationSuccess">
                <div class="text-center">
                  <DialogTitle as="h3" class="text-base font-semibold leading-6 text-gray-900">Fill the reservation form</DialogTitle>
                  <div class="mt-2">
                    <input
                        type="email"
                        v-model="email"
                        placeholder="Email"
                        class="w-full border rounded-md p-2 mb-2"
                    />
                    <input
                        type="number"
                        v-model="guestNumber"
                        placeholder="Guest number"
                        class="w-full border rounded-md p-2 mb-2"
                    />
                    <textarea
                        v-model="additionalInfo"
                        placeholder="Additional informations"
                        class="w-full border rounded-md p-2 mb-2"
                    />
                  </div>
                </div>
                <div class="mt-5 sm:mt-6">
                  <button
                      type="button"
                      class="inline-flex w-full justify-center rounded-md bg-indigo-600 px-3 py-2 text-sm font-semibold text-white shadow-sm hover:bg-indigo-500 focus-visible:outline focus-visible:outline-2 focus-visible:outline-offset-2 focus-visible:outline-indigo-600"
                      @click="reserveArea"
                  >
                    Reserve
                  </button>
                </div>
              </div>
              <div v-else>
                <div class="mx-auto flex h-12 w-12 items-center justify-center rounded-full bg-green-100">
                  <CheckIcon class="h-6 w-6 text-green-600" aria-hidden="true" />
                </div>
                <div class="mt-3 text-center sm:mt-5">
                  <DialogTitle as="h3" class="text-base font-semibold leading-6 text-gray-900">Reservation successful</DialogTitle>
                  <div class="mt-2">
                    <p class="text-sm text-gray-500">Please confirm your reservation through email.</p>
                  </div>
                </div>
                <div class="mt-5 sm:mt-6">
                  <button
                      type="button"
                      class="inline-flex w-full justify-center rounded-md bg-indigo-600 px-3 py-2 text-sm font-semibold text-white shadow-sm hover:bg-indigo-500 focus-visible:outline focus-visible:outline-2 focus-visible:outline-offset-2 focus-visible:outline-indigo-600"
                      @click="closeModalAndRedirect"
                  >
                    Close
                  </button>
                </div>
              </div>
            </DialogPanel>
          </TransitionChild>
        </div>
      </div>
    </Dialog>
  </TransitionRoot>
</template>


<script setup>
import { ref, watch, defineProps } from 'vue'
import { Dialog, DialogPanel, DialogTitle, TransitionChild, TransitionRoot } from '@headlessui/vue'
import { CheckIcon } from '@heroicons/vue/24/outline'
import { useReservations } from '../composables/useReservations'

const props = defineProps({
  open: Boolean,
  selectedDate: String,
  selectedSlot: String,
  areaId: {
    type: Number,
    required: true
  },
  customerId: {
    type: Number,
    required: true
  },
  onClose: Function
})

const open = ref(props.open)
const reservationSuccess = ref(false)
const email = ref('')
const guestNumber = ref(1)
const additionalInfo = ref('')
const reserveError = ref(null)

const { addReservation } = useReservations()

const reserveArea = async () => {
  reserveError.value = null;

  // Parsing the selected slot times
  const [start, end] = props.selectedSlot.split(' - ').map(time => {
    const [hours, minutes] = time.split(':');
    const date = new Date(props.selectedDate);
    date.setHours(hours);
    date.setMinutes(minutes);
    return date;
  });

  // Adjusting for UTC offset
  const offset = start.getTimezoneOffset();
  start.setMinutes(start.getMinutes() - offset);
  end.setMinutes(end.getMinutes() - offset);

  const reservationDto = {
    ReservationFrom: start.toISOString(),
    ReservationTo: end.toISOString(),
    Category: 1,
    NumberOfGuests: guestNumber.value,
    AreaId: props.areaId,
    CustomerId: props.customerId,
    AdditionalInfo: additionalInfo.value
  };

  try {
    await addReservation(reservationDto);
    reservationSuccess.value = true;
  } catch (err) {
    reserveError.value = 'Failed to reserve the area.';
  }
};

const closeModalAndRedirect = () => {
  open.value = false;
  props.onClose();
};

watch(() => props.open, (newVal) => {
  open.value = newVal;
});
</script>
